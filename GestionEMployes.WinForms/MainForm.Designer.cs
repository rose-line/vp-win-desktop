
namespace GestionEMployes.WinForms
{
  partial class MainForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.panel1 = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btnRafraichir = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.lbEmployes = new System.Windows.Forms.ListBox();
      this.btnSauvegarder = new System.Windows.Forms.Button();
      this.comboRole = new System.Windows.Forms.ComboBox();
      this.checkPiloteDeLigne = new System.Windows.Forms.CheckBox();
      this.dtpDateEmbauche = new System.Windows.Forms.DateTimePicker();
      this.tbPrenom = new System.Windows.Forms.TextBox();
      this.tbNom = new System.Windows.Forms.TextBox();
      this.bsEmployes = new System.Windows.Forms.BindingSource(this.components);
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bsEmployes)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnRafraichir);
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 100);
      this.panel1.TabIndex = 0;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(100, 23);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(100, 50);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // btnRafraichir
      // 
      this.btnRafraichir.Location = new System.Drawing.Point(3, 77);
      this.btnRafraichir.Name = "btnRafraichir";
      this.btnRafraichir.Size = new System.Drawing.Size(266, 23);
      this.btnRafraichir.TabIndex = 1;
      this.btnRafraichir.Text = "Rafraîchir";
      this.btnRafraichir.UseVisualStyleBackColor = true;
      this.btnRafraichir.Click += new System.EventHandler(this.btnRafraichir_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.splitContainer1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 100);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(800, 350);
      this.panel2.TabIndex = 1;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.lbEmployes);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.btnSauvegarder);
      this.splitContainer1.Panel2.Controls.Add(this.comboRole);
      this.splitContainer1.Panel2.Controls.Add(this.checkPiloteDeLigne);
      this.splitContainer1.Panel2.Controls.Add(this.dtpDateEmbauche);
      this.splitContainer1.Panel2.Controls.Add(this.tbPrenom);
      this.splitContainer1.Panel2.Controls.Add(this.tbNom);
      this.splitContainer1.Size = new System.Drawing.Size(800, 350);
      this.splitContainer1.SplitterDistance = 266;
      this.splitContainer1.TabIndex = 0;
      // 
      // lbEmployes
      // 
      this.lbEmployes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbEmployes.FormattingEnabled = true;
      this.lbEmployes.ItemHeight = 15;
      this.lbEmployes.Location = new System.Drawing.Point(0, 0);
      this.lbEmployes.Name = "lbEmployes";
      this.lbEmployes.Size = new System.Drawing.Size(266, 350);
      this.lbEmployes.TabIndex = 0;
      // 
      // btnSauvegarder
      // 
      this.btnSauvegarder.Location = new System.Drawing.Point(36, 242);
      this.btnSauvegarder.Name = "btnSauvegarder";
      this.btnSauvegarder.Size = new System.Drawing.Size(112, 23);
      this.btnSauvegarder.TabIndex = 5;
      this.btnSauvegarder.Text = "Sauvegarder";
      this.btnSauvegarder.UseVisualStyleBackColor = true;
      this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
      // 
      // comboRole
      // 
      this.comboRole.FormattingEnabled = true;
      this.comboRole.Location = new System.Drawing.Point(66, 153);
      this.comboRole.Name = "comboRole";
      this.comboRole.Size = new System.Drawing.Size(121, 23);
      this.comboRole.TabIndex = 4;
      // 
      // checkPiloteDeLigne
      // 
      this.checkPiloteDeLigne.AutoSize = true;
      this.checkPiloteDeLigne.Location = new System.Drawing.Point(66, 182);
      this.checkPiloteDeLigne.Name = "checkPiloteDeLigne";
      this.checkPiloteDeLigne.Size = new System.Drawing.Size(82, 19);
      this.checkPiloteDeLigne.TabIndex = 3;
      this.checkPiloteDeLigne.Text = "checkBox1";
      this.checkPiloteDeLigne.UseVisualStyleBackColor = true;
      // 
      // dtpDateEmbauche
      // 
      this.dtpDateEmbauche.Location = new System.Drawing.Point(66, 123);
      this.dtpDateEmbauche.Name = "dtpDateEmbauche";
      this.dtpDateEmbauche.Size = new System.Drawing.Size(200, 23);
      this.dtpDateEmbauche.TabIndex = 2;
      // 
      // tbPrenom
      // 
      this.tbPrenom.Location = new System.Drawing.Point(66, 94);
      this.tbPrenom.Name = "tbPrenom";
      this.tbPrenom.Size = new System.Drawing.Size(100, 23);
      this.tbPrenom.TabIndex = 1;
      // 
      // tbNom
      // 
      this.tbNom.Location = new System.Drawing.Point(66, 65);
      this.tbNom.Name = "tbNom";
      this.tbNom.Size = new System.Drawing.Size(100, 23);
      this.tbNom.TabIndex = 0;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "MainForm";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panel2.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.bsEmployes)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.BindingSource bsEmployes;
    private System.Windows.Forms.ListBox lbEmployes;
    private System.Windows.Forms.TextBox tbNom;
    private System.Windows.Forms.TextBox tbPrenom;
    private System.Windows.Forms.DateTimePicker dtpDateEmbauche;
    private System.Windows.Forms.CheckBox checkPiloteDeLigne;
    private System.Windows.Forms.ComboBox comboRole;
    private System.Windows.Forms.Button btnRafraichir;
    private System.Windows.Forms.Button btnSauvegarder;
  }
}

