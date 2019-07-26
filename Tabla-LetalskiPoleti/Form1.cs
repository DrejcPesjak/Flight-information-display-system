using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryLetalskiPolet;

namespace Tabla_LetalskiPoleti
{
    public partial class Form1 : Form
    {
        int stevilkaLeta = 1;
        Let[] polje = new Let[150];
        TimeSpan zero = new TimeSpan(0,0,0);

        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd. MM. yyyy";  //datum vzleta
            dataGridView1.Columns[4].DefaultCellStyle.Format = "HH:mm";     //ura vzleta po urniku
            dataGridView1.Columns[5].DefaultCellStyle.Format = "HH:mm";     //dejanska ura vzleta 
        }

        private void buttonVstavi_Click(object sender, EventArgs e)
        {
            polje[stevilkaLeta - 1] = new Let(stevilkaLeta, textBoxKrajVzleta.Text, textBoxKrajPristanka.Text, int.Parse(textBoxLetoVzleta.Text), int.Parse(textBoxMesecVzleta.Text), int.Parse(textBoxDanVzleta.Text), int.Parse(textBoxUraVzleta.Text), int.Parse(textBoxMinuteVzleta.Text), int.Parse(textBoxTrajanjeLeta.Text));
            stevilkaLeta++;            
            BrisiTextbox();
        }        

        private void buttonRazveljavi_Click(object sender, EventArgs e)
        {
            BrisiTextbox();
            textBoxKrajVzleta.Enabled = textBoxKrajPristanka.Enabled = textBoxLetoVzleta.Enabled = textBoxMesecVzleta.Enabled = textBoxDanVzleta.Enabled = textBoxTrajanjeLeta.Enabled = true;
            buttonVstavi.Enabled = true; buttonSpremeni.Enabled = false;
        }

        private void buttonSpremeni_Click(object sender, EventArgs e)   
        {
            polje[int.Parse(textBoxStLeta.Text) - 1].NovaUraVzleta(int.Parse(textBoxLetoVzleta.Text), int.Parse(textBoxMesecVzleta.Text), int.Parse(textBoxDanVzleta.Text), int.Parse(textBoxUraVzleta.Text), int.Parse(textBoxMinuteVzleta.Text));
            BrisiTextbox();
            textBoxKrajVzleta.Enabled = textBoxKrajPristanka.Enabled = textBoxLetoVzleta.Enabled = textBoxMesecVzleta.Enabled = textBoxDanVzleta.Enabled = textBoxTrajanjeLeta.Enabled = true;
            buttonVstavi.Enabled = true; buttonSpremeni.Enabled = false;
        }

/*       ne potrebujem, ker timer1_tick naredi isto
        private void buttonTakojOsvezi_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Izpisi_polje_v_DataGridView();
        }
*/
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()) - 1;

            textBoxStLeta.Text = polje[index].StevilkaLeta.ToString();
            textBoxKrajVzleta.Text = polje[index].KrajVzleta();
            textBoxKrajPristanka.Text = polje[index].KrajPristanka;
            textBoxLetoVzleta.Text = polje[index].UraVzleta().Year.ToString();
            textBoxMesecVzleta.Text = polje[index].UraVzleta().Month.ToString();
            textBoxDanVzleta.Text = polje[index].UraVzleta().Day.ToString();
            textBoxUraVzleta.Text = polje[index].UraVzleta().Hour.ToString();
            textBoxMinuteVzleta.Text = polje[index].UraVzleta().Minute.ToString();
            textBoxTrajanjeLeta.Text = polje[index].TrajanjeLeta().ToString();

            buttonVstavi.Enabled = false;
            buttonSpremeni.Enabled = true;

            textBoxKrajVzleta.Enabled = textBoxKrajPristanka.Enabled = textBoxTrajanjeLeta.Enabled = false;
        }

        private void BrisiTextbox()
        {
            textBoxStLeta.Text = stevilkaLeta.ToString();
            textBoxKrajVzleta.Text = textBoxKrajPristanka.Text = textBoxLetoVzleta.Text = textBoxMesecVzleta.Text = textBoxDanVzleta.Text = textBoxUraVzleta.Text = textBoxMinuteVzleta.Text = textBoxTrajanjeLeta.Text = "";
        }

//********************METODA ZA VPIS V DATAGRIDVIEW**************************************
        private void Izpisi_polje_v_DataGridView()          
        {     
            switch (checkBoxPrikazovanje.Checked)
            {
                case true:
                    for(int i = 0; i<stevilkaLeta-1; i++)
                    {
                        if (polje[i].UraVzleta().AddHours(-int.Parse(textBoxPrikazPredLetom.Text)) < DateTime.Now && DateTime.Now < polje[i].UraVzleta().AddHours(int.Parse(textBoxPrikazPoLetu.Text)))
                        {
                            DateTime datumVz = polje[i].UraVzleta();      //datum in čas vzleta, pri vstavljanju vsako posebej
                            DateTime noviCas = polje[i].UraVzleta().Add(polje[i].Zamuda());
                            string zamuda = polje[i].Zamuda().Days.ToString() + "d " + polje[i].Zamuda().Hours.ToString() + "h " + polje[i].Zamuda().Minutes.ToString() + "min";
                            dataGridView1.Rows.Add(polje[i].StevilkaLeta, polje[i].KrajVzleta(), polje[i].KrajPristanka, datumVz.Date, datumVz, noviCas, zamuda);

                            if (TimeSpan.Compare(polje[i].Zamuda(), zero) == 1) dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.HotPink;                            
                        }
                    }
                    break;
                case false:
                    for (int i = 0; i < stevilkaLeta - 1; i++)
                    {
                        DateTime datumVz = polje[i].UraVzleta();      //datum in čas vzleta, pri vstavljanju vsako posebej
                        DateTime noviCas = polje[i].UraVzleta().Add(polje[i].Zamuda());
                        string zamuda = polje[i].Zamuda().Days.ToString() + "d " + polje[i].Zamuda().Hours.ToString() + "h " + polje[i].Zamuda().Minutes.ToString() + "min";
                        dataGridView1.Rows.Add(polje[i].StevilkaLeta, polje[i].KrajVzleta(), polje[i].KrajPristanka, datumVz.Date, datumVz, noviCas, zamuda);

                        if (TimeSpan.Compare(polje[i].Zamuda(), zero) == 1) dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.HotPink;                        
                    }
                    break;
             }            
            dataGridView1.ClearSelection();
        }
//----------------OSVEŽEVANJE-----------------------------------
        private void checkBoxOsvezevanje_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxOsvezevanje.Checked)
            {
                textBoxOsvezevanje.Enabled = true;
                timer1.Start();
            }
            else
            {
                textBoxOsvezevanje.Enabled = false;
                timer1.Stop();
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Izpisi_polje_v_DataGridView();
        }

        private void textBoxOsvezevanje_TextChanged(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(textBoxOsvezevanje.Text) * 1000;
        }
//----------------PRIKAZOVANJE------------------------------------
        private void checkBoxPrikazovanje_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPrikazovanje.Checked) textBoxPrikazPoLetu.Enabled = textBoxPrikazPredLetom.Enabled = true;
            else textBoxPrikazPoLetu.Enabled = textBoxPrikazPredLetom.Enabled = false;    
        }

        private void textBoxKrajVzleta_TextChanged(object sender, EventArgs e)
        {

        }                     
    }
}
