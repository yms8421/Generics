using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BilgeAdam.Numerator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            People = new Queue<Person>();
            SetLabels();
        }
        public int CurrentNumber { get; set; }
        //FIFO : First In First Out
        public Queue<Person> People { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var frm = new frmClient(this);
            frm.ShowDialog();
        }

        public void AddToQueue(string text)
        {
            People.Enqueue(new Person
            {
                Name = text,
                Number = ++CurrentNumber
            });
            SetLabels();
        }

        private void SetLabels()
        {
            lblCurrentMove.Text = CurrentNumber.ToString();
            lblWaitingsCount.Text = People.Count.ToString();
        }

        private void RemoveFromQueue(object sender, EventArgs e)
        {
            if (People.Count == 0)
            {
                return;
            }
            //bkz Peek() -> Dequeue gibi ilk baştaki nesneyi alır ama sıradan düşürmez
            var next = People.Dequeue();
            var btn = sender as Button;
            var parent = btn.Parent as Panel;
            foreach (var control in parent.Controls)
            {
                if (control is Label)
                {
                    (control as Label).Text = next.Number.ToString();
                    break;
                }
            }
            lblWaitingsCount.Text = People.Count.ToString();
        }
    }
}
