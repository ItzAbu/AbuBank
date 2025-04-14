namespace AbuBank
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Admin = new System.Windows.Forms.GroupBox();
            this.gBorn = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gCap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gCitt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gIndir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gSurn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gName = new System.Windows.Forms.TextBox();
            this.UserListG = new System.Windows.Forms.GroupBox();
            this.Saldo = new System.Windows.Forms.ListBox();
            this.Nome = new System.Windows.Forms.ListBox();
            this.Id = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sBorn = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.sEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sTel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.sCap = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.sCitt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.sIndir = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.sSurn = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.sName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.sType = new System.Windows.Forms.ComboBox();
            this.UsersButton = new System.Windows.Forms.RadioButton();
            this.AdminsButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SingMov = new System.Windows.Forms.GroupBox();
            this.Importo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Preleva = new System.Windows.Forms.Button();
            this.Transfer = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.DaId = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.AId = new System.Windows.Forms.TextBox();
            this.Transerisci = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.dAmount = new System.Windows.Forms.TextBox();
            this.Admin.SuspendLayout();
            this.UserListG.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SingMov.SuspendLayout();
            this.Transfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Controls.Add(this.gBorn);
            this.Admin.Controls.Add(this.label8);
            this.Admin.Controls.Add(this.button1);
            this.Admin.Controls.Add(this.label7);
            this.Admin.Controls.Add(this.gEmail);
            this.Admin.Controls.Add(this.label6);
            this.Admin.Controls.Add(this.gTel);
            this.Admin.Controls.Add(this.label5);
            this.Admin.Controls.Add(this.gCap);
            this.Admin.Controls.Add(this.label4);
            this.Admin.Controls.Add(this.gCitt);
            this.Admin.Controls.Add(this.label3);
            this.Admin.Controls.Add(this.gIndir);
            this.Admin.Controls.Add(this.label2);
            this.Admin.Controls.Add(this.gSurn);
            this.Admin.Controls.Add(this.label1);
            this.Admin.Controls.Add(this.gName);
            this.Admin.Location = new System.Drawing.Point(12, 12);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(594, 466);
            this.Admin.TabIndex = 1;
            this.Admin.TabStop = false;
            this.Admin.Text = "Create New User";
            // 
            // gBorn
            // 
            this.gBorn.Location = new System.Drawing.Point(30, 189);
            this.gBorn.Name = "gBorn";
            this.gBorn.Size = new System.Drawing.Size(255, 22);
            this.gBorn.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Data di Nascita";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 228);
            this.button1.TabIndex = 14;
            this.button1.Text = "Crea Utente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            // 
            // gEmail
            // 
            this.gEmail.Location = new System.Drawing.Point(320, 126);
            this.gEmail.Name = "gEmail";
            this.gEmail.Size = new System.Drawing.Size(255, 22);
            this.gEmail.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefono";
            // 
            // gTel
            // 
            this.gTel.Location = new System.Drawing.Point(320, 59);
            this.gTel.Name = "gTel";
            this.gTel.Size = new System.Drawing.Size(255, 22);
            this.gTel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "CAp";
            // 
            // gCap
            // 
            this.gCap.Location = new System.Drawing.Point(30, 407);
            this.gCap.Name = "gCap";
            this.gCap.Size = new System.Drawing.Size(255, 22);
            this.gCap.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Citta";
            // 
            // gCitt
            // 
            this.gCitt.Location = new System.Drawing.Point(30, 339);
            this.gCitt.Name = "gCitt";
            this.gCitt.Size = new System.Drawing.Size(255, 22);
            this.gCitt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Indirizzo";
            // 
            // gIndir
            // 
            this.gIndir.Location = new System.Drawing.Point(30, 262);
            this.gIndir.Name = "gIndir";
            this.gIndir.Size = new System.Drawing.Size(255, 22);
            this.gIndir.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cognome";
            // 
            // gSurn
            // 
            this.gSurn.Location = new System.Drawing.Point(30, 126);
            this.gSurn.Name = "gSurn";
            this.gSurn.Size = new System.Drawing.Size(255, 22);
            this.gSurn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // gName
            // 
            this.gName.Location = new System.Drawing.Point(30, 59);
            this.gName.Name = "gName";
            this.gName.Size = new System.Drawing.Size(255, 22);
            this.gName.TabIndex = 0;
            // 
            // UserListG
            // 
            this.UserListG.Controls.Add(this.panel1);
            this.UserListG.Controls.Add(this.Saldo);
            this.UserListG.Controls.Add(this.Nome);
            this.UserListG.Controls.Add(this.Id);
            this.UserListG.Location = new System.Drawing.Point(1439, 12);
            this.UserListG.Name = "UserListG";
            this.UserListG.Size = new System.Drawing.Size(369, 1050);
            this.UserListG.TabIndex = 3;
            this.UserListG.TabStop = false;
            this.UserListG.Text = "UserList";
            // 
            // Saldo
            // 
            this.Saldo.FormattingEnabled = true;
            this.Saldo.ItemHeight = 16;
            this.Saldo.Location = new System.Drawing.Point(297, 54);
            this.Saldo.Name = "Saldo";
            this.Saldo.Size = new System.Drawing.Size(56, 980);
            this.Saldo.TabIndex = 2;
            // 
            // Nome
            // 
            this.Nome.FormattingEnabled = true;
            this.Nome.ItemHeight = 16;
            this.Nome.Location = new System.Drawing.Point(133, 53);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(158, 980);
            this.Nome.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.FormattingEnabled = true;
            this.Id.ItemHeight = 16;
            this.Id.Location = new System.Drawing.Point(27, 54);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 980);
            this.Id.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sType);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.sBorn);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.sEmail);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.sTel);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.sCap);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.sCitt);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.sIndir);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.sSurn);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.sName);
            this.groupBox1.Location = new System.Drawing.Point(612, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 466);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Staffer";
            // 
            // sBorn
            // 
            this.sBorn.Location = new System.Drawing.Point(30, 189);
            this.sBorn.Name = "sBorn";
            this.sBorn.Size = new System.Drawing.Size(255, 22);
            this.sBorn.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Data di Nascita";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 228);
            this.button2.TabIndex = 14;
            this.button2.Text = "Crea Staffer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(420, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Email";
            // 
            // sEmail
            // 
            this.sEmail.Location = new System.Drawing.Point(320, 126);
            this.sEmail.Name = "sEmail";
            this.sEmail.Size = new System.Drawing.Size(255, 22);
            this.sEmail.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(411, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Telefono";
            // 
            // sTel
            // 
            this.sTel.Location = new System.Drawing.Point(320, 59);
            this.sTel.Name = "sTel";
            this.sTel.Size = new System.Drawing.Size(255, 22);
            this.sTel.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(137, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "CAp";
            // 
            // sCap
            // 
            this.sCap.Location = new System.Drawing.Point(30, 407);
            this.sCap.Name = "sCap";
            this.sCap.Size = new System.Drawing.Size(255, 22);
            this.sCap.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(137, 320);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Citta";
            // 
            // sCitt
            // 
            this.sCitt.Location = new System.Drawing.Point(30, 339);
            this.sCitt.Name = "sCitt";
            this.sCitt.Size = new System.Drawing.Size(255, 22);
            this.sCitt.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(125, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "Indirizzo";
            // 
            // sIndir
            // 
            this.sIndir.Location = new System.Drawing.Point(30, 262);
            this.sIndir.Name = "sIndir";
            this.sIndir.Size = new System.Drawing.Size(255, 22);
            this.sIndir.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(114, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Cognome";
            // 
            // sSurn
            // 
            this.sSurn.Location = new System.Drawing.Point(30, 126);
            this.sSurn.Name = "sSurn";
            this.sSurn.Size = new System.Drawing.Size(255, 22);
            this.sSurn.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(136, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "Nome";
            // 
            // sName
            // 
            this.sName.Location = new System.Drawing.Point(30, 59);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(255, 22);
            this.sName.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(420, 170);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 16);
            this.label17.TabIndex = 18;
            this.label17.Text = "Type";
            // 
            // sType
            // 
            this.sType.FormattingEnabled = true;
            this.sType.Items.AddRange(new object[] {
            "Impiegato",
            "Manager",
            "Admin"});
            this.sType.Location = new System.Drawing.Point(320, 187);
            this.sType.Name = "sType";
            this.sType.Size = new System.Drawing.Size(255, 24);
            this.sType.TabIndex = 19;
            // 
            // UsersButton
            // 
            this.UsersButton.AutoSize = true;
            this.UsersButton.Checked = true;
            this.UsersButton.Location = new System.Drawing.Point(41, 7);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(57, 20);
            this.UsersButton.TabIndex = 18;
            this.UsersButton.TabStop = true;
            this.UsersButton.Text = "User";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.CheckedChanged += new System.EventHandler(this.UsersButton_CheckedChanged);
            // 
            // AdminsButton
            // 
            this.AdminsButton.AutoSize = true;
            this.AdminsButton.Location = new System.Drawing.Point(234, 7);
            this.AdminsButton.Name = "AdminsButton";
            this.AdminsButton.Size = new System.Drawing.Size(66, 20);
            this.AdminsButton.TabIndex = 19;
            this.AdminsButton.Text = "Admin";
            this.AdminsButton.UseVisualStyleBackColor = true;
            this.AdminsButton.CheckedChanged += new System.EventHandler(this.AdminsButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AdminsButton);
            this.panel1.Controls.Add(this.UsersButton);
            this.panel1.Location = new System.Drawing.Point(29, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 35);
            this.panel1.TabIndex = 20;
            // 
            // SingMov
            // 
            this.SingMov.Controls.Add(this.Preleva);
            this.SingMov.Controls.Add(this.button3);
            this.SingMov.Controls.Add(this.label18);
            this.SingMov.Controls.Add(this.Importo);
            this.SingMov.Location = new System.Drawing.Point(12, 492);
            this.SingMov.Name = "SingMov";
            this.SingMov.Size = new System.Drawing.Size(270, 242);
            this.SingMov.TabIndex = 18;
            this.SingMov.TabStop = false;
            this.SingMov.Text = "Deposita/Preleva";
            // 
            // Importo
            // 
            this.Importo.Location = new System.Drawing.Point(0, 58);
            this.Importo.Name = "Importo";
            this.Importo.Size = new System.Drawing.Size(264, 22);
            this.Importo.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(107, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 16);
            this.label18.TabIndex = 1;
            this.label18.Text = "Amount";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(258, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "Deposita";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Preleva
            // 
            this.Preleva.Location = new System.Drawing.Point(6, 170);
            this.Preleva.Name = "Preleva";
            this.Preleva.Size = new System.Drawing.Size(258, 61);
            this.Preleva.TabIndex = 3;
            this.Preleva.Text = "Preleva";
            this.Preleva.UseVisualStyleBackColor = true;
            this.Preleva.Click += new System.EventHandler(this.Preleva_Click);
            // 
            // Transfer
            // 
            this.Transfer.Controls.Add(this.label21);
            this.Transfer.Controls.Add(this.dAmount);
            this.Transfer.Controls.Add(this.Transerisci);
            this.Transfer.Controls.Add(this.label20);
            this.Transfer.Controls.Add(this.AId);
            this.Transfer.Controls.Add(this.label19);
            this.Transfer.Controls.Add(this.DaId);
            this.Transfer.Location = new System.Drawing.Point(328, 492);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(268, 242);
            this.Transfer.TabIndex = 19;
            this.Transfer.TabStop = false;
            this.Transfer.Text = "Trasferisci";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(44, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 16);
            this.label19.TabIndex = 5;
            this.label19.Text = "Da (ID)";
            // 
            // DaId
            // 
            this.DaId.Location = new System.Drawing.Point(22, 58);
            this.DaId.Name = "DaId";
            this.DaId.Size = new System.Drawing.Size(84, 22);
            this.DaId.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(192, 39);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 16);
            this.label20.TabIndex = 7;
            this.label20.Text = "A (ID)";
            // 
            // AId
            // 
            this.AId.Location = new System.Drawing.Point(168, 58);
            this.AId.Name = "AId";
            this.AId.Size = new System.Drawing.Size(85, 22);
            this.AId.TabIndex = 6;
            // 
            // Transerisci
            // 
            this.Transerisci.Location = new System.Drawing.Point(6, 170);
            this.Transerisci.Name = "Transerisci";
            this.Transerisci.Size = new System.Drawing.Size(258, 61);
            this.Transerisci.TabIndex = 4;
            this.Transerisci.Text = "Trasferisci";
            this.Transerisci.UseVisualStyleBackColor = true;
            this.Transerisci.Click += new System.EventHandler(this.Transerisci_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(116, 103);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 16);
            this.label21.TabIndex = 5;
            this.label21.Text = "Amount";
            // 
            // dAmount
            // 
            this.dAmount.Location = new System.Drawing.Point(9, 122);
            this.dAmount.Name = "dAmount";
            this.dAmount.Size = new System.Drawing.Size(255, 22);
            this.dAmount.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1820, 1055);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.SingMov);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UserListG);
            this.Controls.Add(this.Admin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Admin.ResumeLayout(false);
            this.Admin.PerformLayout();
            this.UserListG.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SingMov.ResumeLayout(false);
            this.SingMov.PerformLayout();
            this.Transfer.ResumeLayout(false);
            this.Transfer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Admin;
        private System.Windows.Forms.GroupBox UserListG;
        private System.Windows.Forms.ListBox Saldo;
        private System.Windows.Forms.ListBox Nome;
        private System.Windows.Forms.ListBox Id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gCitt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gIndir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gSurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gTel;
        private System.Windows.Forms.DateTimePicker gBorn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox sType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker sBorn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sTel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox sCap;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox sCitt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox sIndir;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox sSurn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox sName;
        private System.Windows.Forms.RadioButton UsersButton;
        private System.Windows.Forms.RadioButton AdminsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox SingMov;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Importo;
        private System.Windows.Forms.Button Preleva;
        private System.Windows.Forms.GroupBox Transfer;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox AId;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox DaId;
        private System.Windows.Forms.Button Transerisci;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox dAmount;
    }
}

