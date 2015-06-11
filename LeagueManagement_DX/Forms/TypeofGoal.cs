using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LeagueManagement_DX.Forms
{
    public partial class TypeofGoal : DevExpress.XtraEditors.XtraForm
    {
        public TypeofGoal()
        {
            InitializeComponent();
        }

        int tourId;
        public TypeofGoal(int tourid)
        {
            InitializeComponent();
            tourId = tourid;
        }

        private void TypeofGoal_Load(object sender, EventArgs e)
        {
            this.toursTableAdapter1.Fill(leagueDatabaseDataSet.Tours);
            this.goalTypeNameTableAdapter.FillByTourId(leagueDatabaseDataSet.GoalTypeName,tourId);

            label_TourName.Text = this.leagueDatabaseDataSet.Tours.FindById(tourId).TourName;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var goaltyperow = this.leagueDatabaseDataSet.GoalTypeName.NewGoalTypeNameRow();
            goaltyperow.ToursID = tourId;
            goaltyperow.GoalType = customTextBox1.Text.ToString();
            goaltyperow.EndEdit();
            this.leagueDatabaseDataSet.GoalTypeName.AddGoalTypeNameRow(goaltyperow);
            this.goalTypeNameTableAdapter.Update(goaltyperow);
            this.leagueDatabaseDataSet.AcceptChanges();

            this.goalTypeNameTableAdapter.FillByTourId(leagueDatabaseDataSet.GoalTypeName, tourId);
            this.customTextBox1.ResetText();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var temp = new string [3]{"Own Goal", "Normal","Penalty"};
            if (temp.Contains((this.bindingSource_goaltypename.CurrencyManager.Current as DataRowView).Row["GoalType"].ToString()))
            {
                return;
            }
            try
            {
                bindingSource_goaltypename.RemoveCurrent();
                bindingSource_goaltypename.EndEdit();

                this.goalTypeNameTableAdapter.Update(this.leagueDatabaseDataSet.GoalTypeName);
                this.leagueDatabaseDataSet.AcceptChanges();
            }
            catch
            {
                MessageBox.Show("can not delete this type");
            }
        }



    }
}