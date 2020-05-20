using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLoading : Form
    {
        int TimeSecond;

        delegate void Delegat1();
        Delegat1 actualizeBar;

        CancellationTokenSource tokenSource;
        CancellationToken token;
        Action action;
        Task task;
        public FormLoading(int timeSecond)
        {
            TimeSecond = timeSecond;
            InitializeComponent();

            actualizeBar = new Delegat1(ActualizeBar);

            progressBar1.Maximum = 10000;
            progressBar1.Step = 1;
            progressBar1.Value = 0;

            tokenSource = new CancellationTokenSource();
            token = tokenSource.Token;
            action = delegate () { Work(token); };
            task = new Task(action,token);

            LoadingBar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            if (task.Status != TaskStatus.Running) task.Wait();

            DialogResult dialogResult;
            dialogResult = MessageBox.Show("ANULOWANO", "Akcja", MessageBoxButtons.OK);

            while (dialogResult != DialogResult.OK) ;
            this.Close();
        }

        private void LoadingBar()
        {
            progressBar1.Value = 0;
            task.Start();
        }

        private void ActualizeBar(){
            progressBar1.PerformStep();
        }

        private void Work(CancellationToken ct)
        {
            for (int i = 0; i < 10000; i++){
                for (int j = 0; j < 40000 * TimeSecond; j++) j *= 1; //przy procesorze 4Ghz - 1s
                this.progressBar1.Invoke(actualizeBar);
                if(ct.IsCancellationRequested) return;
            }
        }
    }
}
