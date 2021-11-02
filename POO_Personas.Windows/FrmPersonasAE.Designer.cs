
namespace POO_Personas.Windows
{
    partial class FrmPersonasAE
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
            this.LocalidadesComboBox = new System.Windows.Forms.ComboBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FemeninoRadioButton = new System.Windows.Forms.RadioButton();
            this.MasculinoRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DNITextBox = new System.Windows.Forms.TextBox();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.PrimerNombreTextBox = new System.Windows.Forms.TextBox();
            this.SegundoNombreTextBox = new System.Windows.Forms.TextBox();
            this.AyudaToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LocalidadesComboBox
            // 
            this.LocalidadesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalidadesComboBox.FormattingEnabled = true;
            this.LocalidadesComboBox.Location = new System.Drawing.Point(135, 134);
            this.LocalidadesComboBox.Name = "LocalidadesComboBox";
            this.LocalidadesComboBox.Size = new System.Drawing.Size(164, 21);
            this.LocalidadesComboBox.TabIndex = 4;
            this.AyudaToolTip.SetToolTip(this.LocalidadesComboBox, "Seleccione la localidad");
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(135, 162);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(125, 20);
            this.FechaDateTimePicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Localidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Fecha Nac:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FemeninoRadioButton);
            this.groupBox1.Controls.Add(this.MasculinoRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(418, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 65);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seo";
            // 
            // FemeninoRadioButton
            // 
            this.FemeninoRadioButton.AutoSize = true;
            this.FemeninoRadioButton.Location = new System.Drawing.Point(6, 42);
            this.FemeninoRadioButton.Name = "FemeninoRadioButton";
            this.FemeninoRadioButton.Size = new System.Drawing.Size(71, 17);
            this.FemeninoRadioButton.TabIndex = 1;
            this.FemeninoRadioButton.Text = "Femenino";
            this.FemeninoRadioButton.UseVisualStyleBackColor = true;
            // 
            // MasculinoRadioButton
            // 
            this.MasculinoRadioButton.AutoSize = true;
            this.MasculinoRadioButton.Checked = true;
            this.MasculinoRadioButton.Location = new System.Drawing.Point(6, 19);
            this.MasculinoRadioButton.Name = "MasculinoRadioButton";
            this.MasculinoRadioButton.Size = new System.Drawing.Size(73, 17);
            this.MasculinoRadioButton.TabIndex = 0;
            this.MasculinoRadioButton.TabStop = true;
            this.MasculinoRadioButton.Text = "Masculino";
            this.MasculinoRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Primer Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Apellido:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::POO_Personas.Windows.Properties.Resources.Close_2_icon;
            this.btnCancelar.Location = new System.Drawing.Point(436, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 61);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = global::POO_Personas.Windows.Properties.Resources._1462990863_save_as_2;
            this.btnOK.Location = new System.Drawing.Point(33, 205);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 61);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Segundo Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "DNI:";
            // 
            // DNITextBox
            // 
            this.DNITextBox.Location = new System.Drawing.Point(135, 23);
            this.DNITextBox.MaxLength = 8;
            this.DNITextBox.Name = "DNITextBox";
            this.DNITextBox.Size = new System.Drawing.Size(100, 20);
            this.DNITextBox.TabIndex = 0;
            this.AyudaToolTip.SetToolTip(this.DNITextBox, "Ingrese el DNI sin puntos");
            this.DNITextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DNITextBox_KeyPress);
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Location = new System.Drawing.Point(135, 51);
            this.ApellidoTextBox.MaxLength = 50;
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(279, 20);
            this.ApellidoTextBox.TabIndex = 1;
            this.ApellidoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidoTextBox_KeyPress);
            // 
            // PrimerNombreTextBox
            // 
            this.PrimerNombreTextBox.Location = new System.Drawing.Point(135, 80);
            this.PrimerNombreTextBox.MaxLength = 50;
            this.PrimerNombreTextBox.Name = "PrimerNombreTextBox";
            this.PrimerNombreTextBox.Size = new System.Drawing.Size(279, 20);
            this.PrimerNombreTextBox.TabIndex = 2;
            this.PrimerNombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrimerNombreTextBox_KeyPress);
            // 
            // SegundoNombreTextBox
            // 
            this.SegundoNombreTextBox.Location = new System.Drawing.Point(135, 108);
            this.SegundoNombreTextBox.MaxLength = 50;
            this.SegundoNombreTextBox.Name = "SegundoNombreTextBox";
            this.SegundoNombreTextBox.Size = new System.Drawing.Size(279, 20);
            this.SegundoNombreTextBox.TabIndex = 3;
            this.SegundoNombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SegundoNombreTextBox_KeyPress);
            // 
            // FrmPersonasAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 282);
            this.Controls.Add(this.SegundoNombreTextBox);
            this.Controls.Add(this.PrimerNombreTextBox);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.DNITextBox);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.LocalidadesComboBox);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "FrmPersonasAE";
            this.Text = "FrmPersonasAE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox LocalidadesComboBox;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FemeninoRadioButton;
        private System.Windows.Forms.RadioButton MasculinoRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SegundoNombreTextBox;
        private System.Windows.Forms.TextBox PrimerNombreTextBox;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.TextBox DNITextBox;
        private System.Windows.Forms.ToolTip AyudaToolTip;
    }
}