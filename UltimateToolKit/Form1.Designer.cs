namespace UltimateToolKit;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        label1 = new System.Windows.Forms.Label();
        groupBox1 = new System.Windows.Forms.GroupBox();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        labelResult = new System.Windows.Forms.Label();
        buttonCalculate = new System.Windows.Forms.Button();
        textBoxNum1 = new System.Windows.Forms.TextBox();
        comboBoxOperation = new System.Windows.Forms.ComboBox();
        textBoxNum2 = new System.Windows.Forms.TextBox();
        groupBox2 = new System.Windows.Forms.GroupBox();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        buttonGenerate = new System.Windows.Forms.Button();
        textBoxPassword = new System.Windows.Forms.TextBox();
        textBoxLength = new System.Windows.Forms.TextBox();
        ComputerName = new System.Windows.Forms.Label();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 30F);
        label1.Location = new System.Drawing.Point(12, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(541, 57);
        label1.TabIndex = 0;
        label1.Text = "Добро пожаловать в ToolKit";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(labelResult);
        groupBox1.Controls.Add(buttonCalculate);
        groupBox1.Controls.Add(textBoxNum1);
        groupBox1.Controls.Add(comboBoxOperation);
        groupBox1.Controls.Add(textBoxNum2);
        groupBox1.Location = new System.Drawing.Point(45, 91);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(389, 280);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "Калькулятор";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(6, 181);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(178, 16);
        label4.TabIndex = 7;
        label4.Text = "2 число";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(6, 132);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(178, 16);
        label3.TabIndex = 6;
        label3.Text = "1 число";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(16, 32);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(178, 16);
        label2.TabIndex = 5;
        label2.Text = "Выберите действие (+, -, *,/)";

        labelResult.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        labelResult.Location = new System.Drawing.Point(237, 81);
        labelResult.Name = "labelResult";
        labelResult.Size = new System.Drawing.Size(146, 81);
        labelResult.TabIndex = 4;
        labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        buttonCalculate.Location = new System.Drawing.Point(254, 165);
        buttonCalculate.Name = "buttonCalculate";
        buttonCalculate.Size = new System.Drawing.Size(112, 60);
        buttonCalculate.TabIndex = 3;
        buttonCalculate.Text = "Итог";
        buttonCalculate.UseVisualStyleBackColor = true;
        buttonCalculate.Click += buttonCalculate_Click;

        textBoxNum1.Location = new System.Drawing.Point(6, 200);
        textBoxNum1.Name = "textBoxNum1";
        textBoxNum1.Size = new System.Drawing.Size(188, 23);
        textBoxNum1.TabIndex = 2;

        comboBoxOperation.FormattingEnabled = true;
        comboBoxOperation.Location = new System.Drawing.Point(16, 51);
        comboBoxOperation.Name = "comboBoxOperation";
        comboBoxOperation.Size = new System.Drawing.Size(188, 23);
        comboBoxOperation.TabIndex = 1;

        textBoxNum2.Location = new System.Drawing.Point(6, 151);
        textBoxNum2.Name = "textBoxNum2";
        textBoxNum2.Size = new System.Drawing.Size(188, 23);
        textBoxNum2.TabIndex = 0;

        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(buttonGenerate);
        groupBox2.Controls.Add(textBoxPassword);
        groupBox2.Controls.Add(textBoxLength);
        groupBox2.Location = new System.Drawing.Point(463, 90);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(311, 280);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        groupBox2.Text = "Генератор Пароей";

        label6.Location = new System.Drawing.Point(39, 78);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(178, 16);
        label6.TabIndex = 9;
        label6.Text = "Ваш пароль:";

        label5.Location = new System.Drawing.Point(39, 33);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(178, 16);
        label5.TabIndex = 8;
        label5.Text = "Длина пароля";

        buttonGenerate.Location = new System.Drawing.Point(39, 133);
        buttonGenerate.Name = "buttonGenerate";
        buttonGenerate.Size = new System.Drawing.Size(160, 23);
        buttonGenerate.TabIndex = 2;
        buttonGenerate.Text = "Сгенерировать";
        buttonGenerate.UseVisualStyleBackColor = true;
        buttonGenerate.Click += buttonGenerate_Click;

        textBoxPassword.Location = new System.Drawing.Point(39, 97);
        textBoxPassword.Name = "textBoxPassword";
        textBoxPassword.Size = new System.Drawing.Size(114, 23);
        textBoxPassword.TabIndex = 1;

        textBoxLength.Location = new System.Drawing.Point(41, 52);
        textBoxLength.Name = "textBoxLength";
        textBoxLength.Size = new System.Drawing.Size(112, 23);
        textBoxLength.TabIndex = 0;

        ComputerName.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)), System.Drawing.GraphicsUnit.Point, ((byte)204));
        ComputerName.Location = new System.Drawing.Point(22, 404);
        ComputerName.Name = "ComputerName";
        ComputerName.Size = new System.Drawing.Size(268, 37);
        ComputerName.TabIndex = 3;
        ComputerName.Text = "Клик :)";
        ComputerName.Click += ComputerName_Click_1;

        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(ComputerName);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(label1);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Text = "Ultimate ToolKit";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label ComputerName;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button buttonGenerate;

    private System.Windows.Forms.TextBox textBoxPassword;

    private System.Windows.Forms.TextBox textBoxLength;

    private System.Windows.Forms.Button buttonCalculate;
    private System.Windows.Forms.Label labelResult;

    private System.Windows.Forms.TextBox textBoxNum1;

    private System.Windows.Forms.ComboBox comboBoxOperation;

    private System.Windows.Forms.TextBox textBoxNum2;

    private System.Windows.Forms.GroupBox groupBox2;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Label label1;

    #endregion
}