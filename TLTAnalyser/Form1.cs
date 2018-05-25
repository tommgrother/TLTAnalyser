using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TLTAnalyser
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'order_databaseDataSet.view_difference_between_planned_and_actual_completion' table. You can move, or remove it, as needed.
            //this.view_difference_between_planned_and_actual_completionTableAdapter.Fill(this.order_databaseDataSet.view_difference_between_planned_and_actual_completion);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            if (chkExclude.Checked == true)
            {
                sqlCmd.CommandText = String.Format("SELECT * FROM view_difference_between_planned_and_actual_completion WHERE difference_date < 5 and date_completion >= @startdate and date_completion <= @enddate order by date_completion ;");
            }
            else
            {
                sqlCmd.CommandText = String.Format("SELECT * FROM view_difference_between_planned_and_actual_completion WHERE date_completion >= @startdate and date_completion <= @enddate order by date_completion ;");
            }
            
            sqlCmd.Parameters.Add("@startDate", SqlDbType.DateTime);
            sqlCmd.Parameters["@startdate"].Value = this.dtStart.Value ;
            sqlCmd.Parameters.Add("@endDate", SqlDbType.DateTime);
            sqlCmd.Parameters["@enddate"].Value = Convert.ToDateTime(this.dtEnd.Value);

            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);


            double totalDoorsAck = dtRecord.Select("date_complete_on_order_acknowledgement is not null").Length;
            txtDoorCount.Text = totalDoorsAck.ToString();
            double totalDoorsUnAck = dtRecord.Select("date_complete_on_order_acknowledgement is null").Length;
            txtUnAcknowledged.Text = totalDoorsUnAck.ToString();
            double earlyDoors = dtRecord.Select("difference_date < 0 and date_complete_on_order_acknowledgement is not null").Length;
            double onTimeDoors = dtRecord.Select("difference_date = 0 and date_complete_on_order_acknowledgement is not null").Length;
            double lateDoors = dtRecord.Select("difference_date > 0 and date_complete_on_order_acknowledgement is not null").Length;

            txtEarly.Text = earlyDoors.ToString();
            txtOntime.Text = onTimeDoors.ToString();
            txtLate.Text = lateDoors.ToString();
            double PEarly = earlyDoors / totalDoorsAck;
            double POntime = onTimeDoors / totalDoorsAck;
            double PLate = lateDoors / totalDoorsAck;
            


            txtPEarly.Text = PEarly.ToString("P3");
            txtPOnTime.Text = POntime.ToString("P3");
            txtPLate.Text = PLate.ToString("P3");
            dgDoorData.DataSource = dtRecord;

            // }
            //catch (Exception)
            //{
            // MessageBox.Show("Please ensure you enter a valid door number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
