using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class frmScoreCalculator : Form
    {
        List<double> scores = new List<double>();
        double average = 0;
        double scoreTotal = 0;
        double score;
        public frmScoreCalculator()
        {
            InitializeComponent();
        }
        
       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            score = double.Parse(txtScore.Text);
            scores.Add(score);
            txtScore.Items.Add(score);

            for (int i = 0; i < scores.Count; i++)
            {
                scoreTotal += scores[i];
            }

            average = scoreTotal / scores.Count;

            txtAverage.Text = average.ToString();
            txtScoreCount.Text = scores.Count.ToString();
            txtScoreTotal.Text = scoreTotal.ToString();
            txtScore.Text = "";
            txtScore.Focus();

            txtScore.Sorted = true;

        }

        private void btnClearScore_Click(object sender, EventArgs e)
        {
            txtScore.Clear();
            txtScore.Text = "";
            txtScore.Focus();
            scores.Clear();
            average = 0;
            scoreTotal = 0;
            score = 0;
            txtAverage.Text = "";
            txtScoreCount.Text = "";
            txtScoreTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
    }
