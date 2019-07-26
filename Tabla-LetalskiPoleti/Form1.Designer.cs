namespace Tabla_LetalskiPoleti
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxVnos = new System.Windows.Forms.GroupBox();
            this.buttonRazveljavi = new System.Windows.Forms.Button();
            this.buttonSpremeni = new System.Windows.Forms.Button();
            this.buttonVstavi = new System.Windows.Forms.Button();
            this.textBoxKrajPristanka = new System.Windows.Forms.TextBox();
            this.textBoxKrajVzleta = new System.Windows.Forms.TextBox();
            this.textBoxTrajanjeLeta = new System.Windows.Forms.TextBox();
            this.textBoxMinuteVzleta = new System.Windows.Forms.TextBox();
            this.textBoxUraVzleta = new System.Windows.Forms.TextBox();
            this.textBoxLetoVzleta = new System.Windows.Forms.TextBox();
            this.textBoxMesecVzleta = new System.Windows.Forms.TextBox();
            this.textBoxDanVzleta = new System.Windows.Forms.TextBox();
            this.textBoxStLeta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelTrajLet = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelUraVz = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelKrjPri = new System.Windows.Forms.Label();
            this.labelKrjVzl = new System.Windows.Forms.Label();
            this.labelStLet = new System.Windows.Forms.Label();
            this.groupBoxNastavitve = new System.Windows.Forms.GroupBox();
            this.textBoxOsvezevanje = new System.Windows.Forms.TextBox();
            this.textBoxPrikazPoLetu = new System.Windows.Forms.TextBox();
            this.textBoxPrikazPredLetom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxPrikazovanje = new System.Windows.Forms.CheckBox();
            this.checkBoxOsvezevanje = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnStevilkaLeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKrajVzleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKrajPristanka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDatumVzleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUraUrnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUraPravilna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnZamuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonTakojOsvezi = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxVnos.SuspendLayout();
            this.groupBoxNastavitve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxVnos
            // 
            this.groupBoxVnos.Controls.Add(this.buttonRazveljavi);
            this.groupBoxVnos.Controls.Add(this.buttonSpremeni);
            this.groupBoxVnos.Controls.Add(this.buttonVstavi);
            this.groupBoxVnos.Controls.Add(this.textBoxKrajPristanka);
            this.groupBoxVnos.Controls.Add(this.textBoxKrajVzleta);
            this.groupBoxVnos.Controls.Add(this.textBoxTrajanjeLeta);
            this.groupBoxVnos.Controls.Add(this.textBoxMinuteVzleta);
            this.groupBoxVnos.Controls.Add(this.textBoxUraVzleta);
            this.groupBoxVnos.Controls.Add(this.textBoxLetoVzleta);
            this.groupBoxVnos.Controls.Add(this.textBoxMesecVzleta);
            this.groupBoxVnos.Controls.Add(this.textBoxDanVzleta);
            this.groupBoxVnos.Controls.Add(this.textBoxStLeta);
            this.groupBoxVnos.Controls.Add(this.label12);
            this.groupBoxVnos.Controls.Add(this.labelTrajLet);
            this.groupBoxVnos.Controls.Add(this.label10);
            this.groupBoxVnos.Controls.Add(this.label9);
            this.groupBoxVnos.Controls.Add(this.labelUraVz);
            this.groupBoxVnos.Controls.Add(this.label7);
            this.groupBoxVnos.Controls.Add(this.label6);
            this.groupBoxVnos.Controls.Add(this.label5);
            this.groupBoxVnos.Controls.Add(this.labelDatum);
            this.groupBoxVnos.Controls.Add(this.labelKrjPri);
            this.groupBoxVnos.Controls.Add(this.labelKrjVzl);
            this.groupBoxVnos.Controls.Add(this.labelStLet);
            this.groupBoxVnos.Location = new System.Drawing.Point(13, 13);
            this.groupBoxVnos.Name = "groupBoxVnos";
            this.groupBoxVnos.Size = new System.Drawing.Size(278, 213);
            this.groupBoxVnos.TabIndex = 0;
            this.groupBoxVnos.TabStop = false;
            this.groupBoxVnos.Text = "Vstavljanje podatkov";
            // 
            // buttonRazveljavi
            // 
            this.buttonRazveljavi.Location = new System.Drawing.Point(195, 184);
            this.buttonRazveljavi.Name = "buttonRazveljavi";
            this.buttonRazveljavi.Size = new System.Drawing.Size(75, 23);
            this.buttonRazveljavi.TabIndex = 11;
            this.buttonRazveljavi.Text = "Razveljavi";
            this.buttonRazveljavi.UseVisualStyleBackColor = true;
            this.buttonRazveljavi.Click += new System.EventHandler(this.buttonRazveljavi_Click);
            // 
            // buttonSpremeni
            // 
            this.buttonSpremeni.Enabled = false;
            this.buttonSpremeni.Location = new System.Drawing.Point(119, 184);
            this.buttonSpremeni.Name = "buttonSpremeni";
            this.buttonSpremeni.Size = new System.Drawing.Size(75, 23);
            this.buttonSpremeni.TabIndex = 10;
            this.buttonSpremeni.Text = "Spremeni";
            this.buttonSpremeni.UseVisualStyleBackColor = true;
            this.buttonSpremeni.Click += new System.EventHandler(this.buttonSpremeni_Click);
            // 
            // buttonVstavi
            // 
            this.buttonVstavi.Location = new System.Drawing.Point(6, 184);
            this.buttonVstavi.Name = "buttonVstavi";
            this.buttonVstavi.Size = new System.Drawing.Size(75, 23);
            this.buttonVstavi.TabIndex = 9;
            this.buttonVstavi.Text = "Vstavi";
            this.buttonVstavi.UseVisualStyleBackColor = true;
            this.buttonVstavi.Click += new System.EventHandler(this.buttonVstavi_Click);
            // 
            // textBoxKrajPristanka
            // 
            this.textBoxKrajPristanka.Location = new System.Drawing.Point(86, 70);
            this.textBoxKrajPristanka.Name = "textBoxKrajPristanka";
            this.textBoxKrajPristanka.Size = new System.Drawing.Size(120, 20);
            this.textBoxKrajPristanka.TabIndex = 2;
            // 
            // textBoxKrajVzleta
            // 
            this.textBoxKrajVzleta.Location = new System.Drawing.Point(86, 44);
            this.textBoxKrajVzleta.Name = "textBoxKrajVzleta";
            this.textBoxKrajVzleta.Size = new System.Drawing.Size(120, 20);
            this.textBoxKrajVzleta.TabIndex = 1;
            this.textBoxKrajVzleta.TextChanged += new System.EventHandler(this.textBoxKrajVzleta_TextChanged);
            // 
            // textBoxTrajanjeLeta
            // 
            this.textBoxTrajanjeLeta.Location = new System.Drawing.Point(86, 147);
            this.textBoxTrajanjeLeta.Name = "textBoxTrajanjeLeta";
            this.textBoxTrajanjeLeta.Size = new System.Drawing.Size(48, 20);
            this.textBoxTrajanjeLeta.TabIndex = 8;
            // 
            // textBoxMinuteVzleta
            // 
            this.textBoxMinuteVzleta.Location = new System.Drawing.Point(164, 120);
            this.textBoxMinuteVzleta.Name = "textBoxMinuteVzleta";
            this.textBoxMinuteVzleta.Size = new System.Drawing.Size(30, 20);
            this.textBoxMinuteVzleta.TabIndex = 7;
            // 
            // textBoxUraVzleta
            // 
            this.textBoxUraVzleta.Location = new System.Drawing.Point(104, 120);
            this.textBoxUraVzleta.Name = "textBoxUraVzleta";
            this.textBoxUraVzleta.Size = new System.Drawing.Size(30, 20);
            this.textBoxUraVzleta.TabIndex = 6;
            // 
            // textBoxLetoVzleta
            // 
            this.textBoxLetoVzleta.Location = new System.Drawing.Point(221, 94);
            this.textBoxLetoVzleta.Name = "textBoxLetoVzleta";
            this.textBoxLetoVzleta.Size = new System.Drawing.Size(49, 20);
            this.textBoxLetoVzleta.TabIndex = 5;
            // 
            // textBoxMesecVzleta
            // 
            this.textBoxMesecVzleta.Location = new System.Drawing.Point(164, 95);
            this.textBoxMesecVzleta.Name = "textBoxMesecVzleta";
            this.textBoxMesecVzleta.Size = new System.Drawing.Size(30, 20);
            this.textBoxMesecVzleta.TabIndex = 4;
            // 
            // textBoxDanVzleta
            // 
            this.textBoxDanVzleta.Location = new System.Drawing.Point(104, 95);
            this.textBoxDanVzleta.Name = "textBoxDanVzleta";
            this.textBoxDanVzleta.Size = new System.Drawing.Size(30, 20);
            this.textBoxDanVzleta.TabIndex = 3;
            // 
            // textBoxStLeta
            // 
            this.textBoxStLeta.Enabled = false;
            this.textBoxStLeta.Location = new System.Drawing.Point(87, 18);
            this.textBoxStLeta.Name = "textBoxStLeta";
            this.textBoxStLeta.Size = new System.Drawing.Size(30, 20);
            this.textBoxStLeta.TabIndex = 0;
            this.textBoxStLeta.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(135, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "min";
            // 
            // labelTrajLet
            // 
            this.labelTrajLet.AutoSize = true;
            this.labelTrajLet.Location = new System.Drawing.Point(6, 150);
            this.labelTrajLet.Name = "labelTrajLet";
            this.labelTrajLet.Size = new System.Drawing.Size(68, 13);
            this.labelTrajLet.TabIndex = 10;
            this.labelTrajLet.Text = "Trajanje leta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(140, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "min:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "h:";
            // 
            // labelUraVz
            // 
            this.labelUraVz.AutoSize = true;
            this.labelUraVz.Location = new System.Drawing.Point(6, 125);
            this.labelUraVz.Name = "labelUraVz";
            this.labelUraVz.Size = new System.Drawing.Size(58, 13);
            this.labelUraVz.TabIndex = 7;
            this.labelUraVz.Text = "Ura vzleta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "yy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "mm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "dd:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(6, 99);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(72, 13);
            this.labelDatum.TabIndex = 3;
            this.labelDatum.Text = "Datum vzleta:";
            // 
            // labelKrjPri
            // 
            this.labelKrjPri.AutoSize = true;
            this.labelKrjPri.Location = new System.Drawing.Point(6, 71);
            this.labelKrjPri.Name = "labelKrjPri";
            this.labelKrjPri.Size = new System.Drawing.Size(74, 13);
            this.labelKrjPri.TabIndex = 2;
            this.labelKrjPri.Text = "Kraj pristanka:";
            // 
            // labelKrjVzl
            // 
            this.labelKrjVzl.AutoSize = true;
            this.labelKrjVzl.Location = new System.Drawing.Point(6, 47);
            this.labelKrjVzl.Name = "labelKrjVzl";
            this.labelKrjVzl.Size = new System.Drawing.Size(59, 13);
            this.labelKrjVzl.TabIndex = 1;
            this.labelKrjVzl.Text = "Kraj vzleta:";
            // 
            // labelStLet
            // 
            this.labelStLet.AutoSize = true;
            this.labelStLet.Location = new System.Drawing.Point(6, 19);
            this.labelStLet.Name = "labelStLet";
            this.labelStLet.Size = new System.Drawing.Size(68, 13);
            this.labelStLet.TabIndex = 0;
            this.labelStLet.Text = "Številka leta:";
            // 
            // groupBoxNastavitve
            // 
            this.groupBoxNastavitve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxNastavitve.Controls.Add(this.textBoxOsvezevanje);
            this.groupBoxNastavitve.Controls.Add(this.textBoxPrikazPoLetu);
            this.groupBoxNastavitve.Controls.Add(this.textBoxPrikazPredLetom);
            this.groupBoxNastavitve.Controls.Add(this.label3);
            this.groupBoxNastavitve.Controls.Add(this.label2);
            this.groupBoxNastavitve.Controls.Add(this.label1);
            this.groupBoxNastavitve.Controls.Add(this.checkBoxPrikazovanje);
            this.groupBoxNastavitve.Controls.Add(this.checkBoxOsvezevanje);
            this.groupBoxNastavitve.Location = new System.Drawing.Point(298, 13);
            this.groupBoxNastavitve.Name = "groupBoxNastavitve";
            this.groupBoxNastavitve.Size = new System.Drawing.Size(460, 213);
            this.groupBoxNastavitve.TabIndex = 1;
            this.groupBoxNastavitve.TabStop = false;
            this.groupBoxNastavitve.Text = "Nastavitve";
            // 
            // textBoxOsvezevanje
            // 
            this.textBoxOsvezevanje.Enabled = false;
            this.textBoxOsvezevanje.Location = new System.Drawing.Point(125, 44);
            this.textBoxOsvezevanje.Name = "textBoxOsvezevanje";
            this.textBoxOsvezevanje.Size = new System.Drawing.Size(30, 20);
            this.textBoxOsvezevanje.TabIndex = 7;
            this.textBoxOsvezevanje.Text = "10";
            this.textBoxOsvezevanje.TextChanged += new System.EventHandler(this.textBoxOsvezevanje_TextChanged);
            // 
            // textBoxPrikazPoLetu
            // 
            this.textBoxPrikazPoLetu.Enabled = false;
            this.textBoxPrikazPoLetu.Location = new System.Drawing.Point(45, 149);
            this.textBoxPrikazPoLetu.Name = "textBoxPrikazPoLetu";
            this.textBoxPrikazPoLetu.Size = new System.Drawing.Size(30, 20);
            this.textBoxPrikazPoLetu.TabIndex = 6;
            this.textBoxPrikazPoLetu.Text = "1";
            // 
            // textBoxPrikazPredLetom
            // 
            this.textBoxPrikazPredLetom.Enabled = false;
            this.textBoxPrikazPredLetom.Location = new System.Drawing.Point(45, 122);
            this.textBoxPrikazPredLetom.Name = "textBoxPrikazPredLetom";
            this.textBoxPrikazPredLetom.Size = new System.Drawing.Size(30, 20);
            this.textBoxPrikazPredLetom.TabIndex = 5;
            this.textBoxPrikazPredLetom.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ur po letu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ur pred letom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Osveževanje na            sec";
            // 
            // checkBoxPrikazovanje
            // 
            this.checkBoxPrikazovanje.AutoSize = true;
            this.checkBoxPrikazovanje.Location = new System.Drawing.Point(7, 93);
            this.checkBoxPrikazovanje.Name = "checkBoxPrikazovanje";
            this.checkBoxPrikazovanje.Size = new System.Drawing.Size(165, 17);
            this.checkBoxPrikazovanje.TabIndex = 1;
            this.checkBoxPrikazovanje.Text = "Prikazovanje letov le v okviru";
            this.checkBoxPrikazovanje.UseVisualStyleBackColor = true;
            this.checkBoxPrikazovanje.CheckedChanged += new System.EventHandler(this.checkBoxPrikazovanje_CheckedChanged);
            // 
            // checkBoxOsvezevanje
            // 
            this.checkBoxOsvezevanje.AutoSize = true;
            this.checkBoxOsvezevanje.Location = new System.Drawing.Point(7, 19);
            this.checkBoxOsvezevanje.Name = "checkBoxOsvezevanje";
            this.checkBoxOsvezevanje.Size = new System.Drawing.Size(171, 17);
            this.checkBoxOsvezevanje.TabIndex = 0;
            this.checkBoxOsvezevanje.Text = "Avtomatsko osveževanje table";
            this.checkBoxOsvezevanje.UseVisualStyleBackColor = true;
            this.checkBoxOsvezevanje.CheckedChanged += new System.EventHandler(this.checkBoxOsvezevanje_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStevilkaLeta,
            this.ColumnKrajVzleta,
            this.ColumnKrajPristanka,
            this.ColumnDatumVzleta,
            this.ColumnUraUrnik,
            this.ColumnUraPravilna,
            this.ColumnZamuda});
            this.dataGridView1.Location = new System.Drawing.Point(13, 233);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(745, 256);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // ColumnStevilkaLeta
            // 
            this.ColumnStevilkaLeta.HeaderText = "Številka leta";
            this.ColumnStevilkaLeta.Name = "ColumnStevilkaLeta";
            this.ColumnStevilkaLeta.ReadOnly = true;
            // 
            // ColumnKrajVzleta
            // 
            this.ColumnKrajVzleta.HeaderText = "Kraj vzleta";
            this.ColumnKrajVzleta.Name = "ColumnKrajVzleta";
            this.ColumnKrajVzleta.ReadOnly = true;
            // 
            // ColumnKrajPristanka
            // 
            this.ColumnKrajPristanka.HeaderText = "Kraj pristanka";
            this.ColumnKrajPristanka.Name = "ColumnKrajPristanka";
            this.ColumnKrajPristanka.ReadOnly = true;
            // 
            // ColumnDatumVzleta
            // 
            this.ColumnDatumVzleta.HeaderText = "Datum vzleta";
            this.ColumnDatumVzleta.Name = "ColumnDatumVzleta";
            this.ColumnDatumVzleta.ReadOnly = true;
            // 
            // ColumnUraUrnik
            // 
            this.ColumnUraUrnik.HeaderText = "Ura vzleta po urniku";
            this.ColumnUraUrnik.Name = "ColumnUraUrnik";
            this.ColumnUraUrnik.ReadOnly = true;
            // 
            // ColumnUraPravilna
            // 
            this.ColumnUraPravilna.HeaderText = "Dejanska ura vzleta";
            this.ColumnUraPravilna.Name = "ColumnUraPravilna";
            this.ColumnUraPravilna.ReadOnly = true;
            // 
            // ColumnZamuda
            // 
            this.ColumnZamuda.HeaderText = "Zamuda";
            this.ColumnZamuda.Name = "ColumnZamuda";
            this.ColumnZamuda.ReadOnly = true;
            // 
            // buttonTakojOsvezi
            // 
            this.buttonTakojOsvezi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTakojOsvezi.Location = new System.Drawing.Point(13, 496);
            this.buttonTakojOsvezi.Name = "buttonTakojOsvezi";
            this.buttonTakojOsvezi.Size = new System.Drawing.Size(745, 23);
            this.buttonTakojOsvezi.TabIndex = 3;
            this.buttonTakojOsvezi.Text = "Osveži tabelo";
            this.buttonTakojOsvezi.UseVisualStyleBackColor = true;
            this.buttonTakojOsvezi.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 527);
            this.Controls.Add(this.buttonTakojOsvezi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxNastavitve);
            this.Controls.Add(this.groupBoxVnos);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Letalska Tabla";
            this.groupBoxVnos.ResumeLayout(false);
            this.groupBoxVnos.PerformLayout();
            this.groupBoxNastavitve.ResumeLayout(false);
            this.groupBoxNastavitve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVnos;
        private System.Windows.Forms.Button buttonRazveljavi;
        private System.Windows.Forms.Button buttonSpremeni;
        private System.Windows.Forms.Button buttonVstavi;
        private System.Windows.Forms.TextBox textBoxKrajPristanka;
        private System.Windows.Forms.TextBox textBoxKrajVzleta;
        private System.Windows.Forms.TextBox textBoxTrajanjeLeta;
        private System.Windows.Forms.TextBox textBoxMinuteVzleta;
        private System.Windows.Forms.TextBox textBoxUraVzleta;
        private System.Windows.Forms.TextBox textBoxLetoVzleta;
        private System.Windows.Forms.TextBox textBoxMesecVzleta;
        private System.Windows.Forms.TextBox textBoxDanVzleta;
        private System.Windows.Forms.TextBox textBoxStLeta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelTrajLet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelUraVz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelKrjPri;
        private System.Windows.Forms.Label labelKrjVzl;
        private System.Windows.Forms.Label labelStLet;
        private System.Windows.Forms.GroupBox groupBoxNastavitve;
        private System.Windows.Forms.TextBox textBoxOsvezevanje;
        private System.Windows.Forms.TextBox textBoxPrikazPoLetu;
        private System.Windows.Forms.TextBox textBoxPrikazPredLetom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxPrikazovanje;
        private System.Windows.Forms.CheckBox checkBoxOsvezevanje;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonTakojOsvezi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStevilkaLeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKrajVzleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKrajPristanka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDatumVzleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUraUrnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUraPravilna;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnZamuda;
        private System.Windows.Forms.Timer timer1;
    }
}

