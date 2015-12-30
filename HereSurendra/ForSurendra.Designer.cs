namespace HereSurendra
{
    partial class ForSurendra
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
            this.token_text = new System.Windows.Forms.TextBox();
            this.jwt_text = new System.Windows.Forms.TextBox();
            this.Clipboard_button = new System.Windows.Forms.Button();
            this.Tokenify_Key_button = new System.Windows.Forms.Button();
            this.service_drop = new System.Windows.Forms.ComboBox();
            this.Tokenify_Service_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.env_drop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClaimsLbl = new System.Windows.Forms.Label();
            this.ClaimType1 = new System.Windows.Forms.TextBox();
            this.ClaimType2 = new System.Windows.Forms.TextBox();
            this.ClaimType3 = new System.Windows.Forms.TextBox();
            this.ClaimValue1 = new System.Windows.Forms.TextBox();
            this.ClaimValue2 = new System.Windows.Forms.TextBox();
            this.ClaimValue3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.role1 = new System.Windows.Forms.TextBox();
            this.role2 = new System.Windows.Forms.TextBox();
            this.role4 = new System.Windows.Forms.TextBox();
            this.role3 = new System.Windows.Forms.TextBox();
            this.role5 = new System.Windows.Forms.TextBox();
            this.role6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // token_text
            // 
            this.token_text.Location = new System.Drawing.Point(12, 28);
            this.token_text.Name = "token_text";
            this.token_text.Size = new System.Drawing.Size(298, 20);
            this.token_text.TabIndex = 0;
            this.token_text.Text = "SOME_SUPER_SECRET_SHARED_KEY!!!";
            // 
            // jwt_text
            // 
            this.jwt_text.Location = new System.Drawing.Point(12, 111);
            this.jwt_text.Name = "jwt_text";
            this.jwt_text.Size = new System.Drawing.Size(616, 20);
            this.jwt_text.TabIndex = 1;
            // 
            // Clipboard_button
            // 
            this.Clipboard_button.Location = new System.Drawing.Point(634, 100);
            this.Clipboard_button.Name = "Clipboard_button";
            this.Clipboard_button.Size = new System.Drawing.Size(144, 41);
            this.Clipboard_button.TabIndex = 2;
            this.Clipboard_button.Text = "Copy To Clipboard";
            this.Clipboard_button.UseVisualStyleBackColor = true;
            this.Clipboard_button.Click += new System.EventHandler(this.CopyToClipboard);
            // 
            // Tokenify_Key_button
            // 
            this.Tokenify_Key_button.Location = new System.Drawing.Point(316, 10);
            this.Tokenify_Key_button.Name = "Tokenify_Key_button";
            this.Tokenify_Key_button.Size = new System.Drawing.Size(93, 53);
            this.Tokenify_Key_button.TabIndex = 3;
            this.Tokenify_Key_button.Text = "Tokenify";
            this.Tokenify_Key_button.UseVisualStyleBackColor = true;
            this.Tokenify_Key_button.Click += new System.EventHandler(this.TokenifyKey);
            // 
            // service_drop
            // 
            this.service_drop.FormattingEnabled = true;
            this.service_drop.Items.AddRange(new object[] {
            "InventoryService",
            "MessagingService",
            "CommunityService",
            "FraudDetectService",
            "FreightQuoteService",
            "RatingsAndReviewsService",
            "ShoppingService"});
            this.service_drop.Location = new System.Drawing.Point(501, 27);
            this.service_drop.Name = "service_drop";
            this.service_drop.Size = new System.Drawing.Size(178, 21);
            this.service_drop.TabIndex = 4;
            // 
            // Tokenify_Service_button
            // 
            this.Tokenify_Service_button.Location = new System.Drawing.Point(685, 9);
            this.Tokenify_Service_button.Name = "Tokenify_Service_button";
            this.Tokenify_Service_button.Size = new System.Drawing.Size(93, 50);
            this.Tokenify_Service_button.TabIndex = 5;
            this.Tokenify_Service_button.Text = "Tokenify";
            this.Tokenify_Service_button.UseVisualStyleBackColor = true;
            this.Tokenify_Service_button.Click += new System.EventHandler(this.TokenifyService);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "TokenKey";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Authorization Header";
            // 
            // env_drop
            // 
            this.env_drop.FormattingEnabled = true;
            this.env_drop.Items.AddRange(new object[] {
            "None",
            "DEV",
            "QA",
            "PE",
            "PROD"});
            this.env_drop.Location = new System.Drawing.Point(425, 27);
            this.env_drop.Name = "env_drop";
            this.env_drop.Size = new System.Drawing.Size(60, 21);
            this.env_drop.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "env";
            // 
            // ClaimsLbl
            // 
            this.ClaimsLbl.AutoSize = true;
            this.ClaimsLbl.Location = new System.Drawing.Point(15, 169);
            this.ClaimsLbl.Name = "ClaimsLbl";
            this.ClaimsLbl.Size = new System.Drawing.Size(37, 13);
            this.ClaimsLbl.TabIndex = 11;
            this.ClaimsLbl.Text = "Claims";
            // 
            // ClaimType1
            // 
            this.ClaimType1.Location = new System.Drawing.Point(18, 208);
            this.ClaimType1.Name = "ClaimType1";
            this.ClaimType1.Size = new System.Drawing.Size(194, 20);
            this.ClaimType1.TabIndex = 12;
            // 
            // ClaimType2
            // 
            this.ClaimType2.Location = new System.Drawing.Point(18, 235);
            this.ClaimType2.Name = "ClaimType2";
            this.ClaimType2.Size = new System.Drawing.Size(194, 20);
            this.ClaimType2.TabIndex = 14;
            // 
            // ClaimType3
            // 
            this.ClaimType3.Location = new System.Drawing.Point(18, 262);
            this.ClaimType3.Name = "ClaimType3";
            this.ClaimType3.Size = new System.Drawing.Size(194, 20);
            this.ClaimType3.TabIndex = 16;
            // 
            // ClaimValue1
            // 
            this.ClaimValue1.AcceptsTab = true;
            this.ClaimValue1.Location = new System.Drawing.Point(219, 207);
            this.ClaimValue1.Name = "ClaimValue1";
            this.ClaimValue1.Size = new System.Drawing.Size(190, 20);
            this.ClaimValue1.TabIndex = 13;
            // 
            // ClaimValue2
            // 
            this.ClaimValue2.Location = new System.Drawing.Point(219, 235);
            this.ClaimValue2.Name = "ClaimValue2";
            this.ClaimValue2.Size = new System.Drawing.Size(190, 20);
            this.ClaimValue2.TabIndex = 15;
            // 
            // ClaimValue3
            // 
            this.ClaimValue3.Location = new System.Drawing.Point(219, 261);
            this.ClaimValue3.Name = "ClaimValue3";
            this.ClaimValue3.Size = new System.Drawing.Size(190, 20);
            this.ClaimValue3.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Roles";
            // 
            // role1
            // 
            this.role1.AcceptsTab = true;
            this.role1.Location = new System.Drawing.Point(472, 207);
            this.role1.Name = "role1";
            this.role1.Size = new System.Drawing.Size(156, 20);
            this.role1.TabIndex = 21;
            // 
            // role2
            // 
            this.role2.AcceptsTab = true;
            this.role2.Location = new System.Drawing.Point(472, 233);
            this.role2.Name = "role2";
            this.role2.Size = new System.Drawing.Size(156, 20);
            this.role2.TabIndex = 22;
            // 
            // role4
            // 
            this.role4.AcceptsTab = true;
            this.role4.Location = new System.Drawing.Point(634, 208);
            this.role4.Name = "role4";
            this.role4.Size = new System.Drawing.Size(144, 20);
            this.role4.TabIndex = 23;
            // 
            // role3
            // 
            this.role3.AcceptsTab = true;
            this.role3.Location = new System.Drawing.Point(472, 262);
            this.role3.Name = "role3";
            this.role3.Size = new System.Drawing.Size(156, 20);
            this.role3.TabIndex = 24;
            // 
            // role5
            // 
            this.role5.AcceptsTab = true;
            this.role5.Location = new System.Drawing.Point(634, 233);
            this.role5.Name = "role5";
            this.role5.Size = new System.Drawing.Size(144, 20);
            this.role5.TabIndex = 25;
            // 
            // role6
            // 
            this.role6.AcceptsTab = true;
            this.role6.Location = new System.Drawing.Point(634, 259);
            this.role6.Name = "role6";
            this.role6.Size = new System.Drawing.Size(144, 20);
            this.role6.TabIndex = 26;
            // 
            // ForSurendra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 292);
            this.Controls.Add(this.role6);
            this.Controls.Add(this.role5);
            this.Controls.Add(this.role3);
            this.Controls.Add(this.role4);
            this.Controls.Add(this.role2);
            this.Controls.Add(this.role1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClaimValue3);
            this.Controls.Add(this.ClaimValue2);
            this.Controls.Add(this.ClaimValue1);
            this.Controls.Add(this.ClaimType3);
            this.Controls.Add(this.ClaimType2);
            this.Controls.Add(this.ClaimType1);
            this.Controls.Add(this.ClaimsLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.env_drop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tokenify_Service_button);
            this.Controls.Add(this.service_drop);
            this.Controls.Add(this.Tokenify_Key_button);
            this.Controls.Add(this.Clipboard_button);
            this.Controls.Add(this.jwt_text);
            this.Controls.Add(this.token_text);
            this.Name = "ForSurendra";
            this.Text = "For Surendra <3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox token_text;
        private System.Windows.Forms.TextBox jwt_text;
        private System.Windows.Forms.Button Clipboard_button;
        private System.Windows.Forms.Button Tokenify_Key_button;
        private System.Windows.Forms.ComboBox service_drop;
        private System.Windows.Forms.Button Tokenify_Service_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox env_drop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ClaimsLbl;
        private System.Windows.Forms.TextBox ClaimType1;
        private System.Windows.Forms.TextBox ClaimType2;
        private System.Windows.Forms.TextBox ClaimType3;
        private System.Windows.Forms.TextBox ClaimValue1;
        private System.Windows.Forms.TextBox ClaimValue2;
        private System.Windows.Forms.TextBox ClaimValue3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox role1;
        private System.Windows.Forms.TextBox role2;
        private System.Windows.Forms.TextBox role4;
        private System.Windows.Forms.TextBox role3;
        private System.Windows.Forms.TextBox role5;
        private System.Windows.Forms.TextBox role6;
    }
}

