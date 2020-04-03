namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DisciplineName = new System.Windows.Forms.TextBox();
            this.DisciplineLabel = new System.Windows.Forms.Label();
            this.AddAll = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Button();
            this.SemestrValue = new System.Windows.Forms.ComboBox();
            this.SemestrLabel = new System.Windows.Forms.Label();
            this.CouseLabel = new System.Windows.Forms.Label();
            this.CourseValue = new System.Windows.Forms.NumericUpDown();
            this.SpecializationDEVI = new System.Windows.Forms.CheckBox();
            this.SpecializationISIT = new System.Windows.Forms.CheckBox();
            this.SpecializationPOIBMS = new System.Windows.Forms.CheckBox();
            this.SpecializationPOIT = new System.Windows.Forms.CheckBox();
            this.Specialization = new System.Windows.Forms.Label();
            this.LabsCountValue = new System.Windows.Forms.Label();
            this.LabsCountLabel = new System.Windows.Forms.Label();
            this.LabsCount = new System.Windows.Forms.TrackBar();
            this.LecturesCountValue = new System.Windows.Forms.Label();
            this.LecturesCountLabel = new System.Windows.Forms.Label();
            this.LecturesCount = new System.Windows.Forms.TrackBar();
            this.test = new System.Windows.Forms.RadioButton();
            this.exam = new System.Windows.Forms.RadioButton();
            this.DisciplineControl = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CorpusAydit = new System.Windows.Forms.NumericUpDown();
            this.NumberAudit = new System.Windows.Forms.NumericUpDown();
            this.SNP = new System.Windows.Forms.TextBox();
            this.Pulpit = new System.Windows.Forms.TextBox();
            this.Lector = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.BookList = new System.Windows.Forms.ListView();
            this.BookName = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.CreationDate = new System.Windows.Forms.DateTimePicker();
            this.Literature = new System.Windows.Forms.Label();
            this.OutputList = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Search = new System.Windows.Forms.ToolStripMenuItem();
            this.LectorSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.SemestrSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.CourseSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.Sort = new System.Windows.Forms.ToolStripMenuItem();
            this.LecturesSort = new System.Windows.Forms.ToolStripMenuItem();
            this.PassTypeSort = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.Example1 = new System.Windows.Forms.Button();
            this.fixTool = new System.Windows.Forms.ToolStrip();
            this.SearchTool = new System.Windows.Forms.ToolStripDropDownButton();
            this.LectorSearchTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SemestrSearcheTool = new System.Windows.Forms.ToolStripMenuItem();
            this.CourseSearchTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SortTool = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.PassTypeSortTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTool = new System.Windows.Forms.ToolStripButton();
            this.AboutTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fastentool = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CountOfObjectLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CountOfObject = new System.Windows.Forms.ToolStripStatusLabel();
            this.LastActionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.DataTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateTimeChange = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CourseValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturesCount)).BeginInit();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CorpusAydit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberAudit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.fixTool.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisciplineName
            // 
            this.DisciplineName.Location = new System.Drawing.Point(144, 87);
            this.DisciplineName.Margin = new System.Windows.Forms.Padding(4);
            this.DisciplineName.MaxLength = 20;
            this.DisciplineName.Name = "DisciplineName";
            this.DisciplineName.Size = new System.Drawing.Size(356, 22);
            this.DisciplineName.TabIndex = 3;
            this.DisciplineName.Text = "Название дисциплины";
            this.DisciplineName.Enter += new System.EventHandler(this.DisciplineName_Enter);
            // 
            // DisciplineLabel
            // 
            this.DisciplineLabel.AutoSize = true;
            this.DisciplineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisciplineLabel.Location = new System.Drawing.Point(13, 87);
            this.DisciplineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DisciplineLabel.Name = "DisciplineLabel";
            this.DisciplineLabel.Size = new System.Drawing.Size(116, 20);
            this.DisciplineLabel.TabIndex = 2;
            this.DisciplineLabel.Text = "Дисциплина:";
            // 
            // AddAll
            // 
            this.AddAll.Location = new System.Drawing.Point(17, 127);
            this.AddAll.Margin = new System.Windows.Forms.Padding(4);
            this.AddAll.Name = "AddAll";
            this.AddAll.Size = new System.Drawing.Size(100, 28);
            this.AddAll.TabIndex = 40;
            this.AddAll.Text = "Добавить";
            this.AddAll.UseVisualStyleBackColor = true;
            this.AddAll.Click += new System.EventHandler(this.AddAll_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(135, 127);
            this.Output.Margin = new System.Windows.Forms.Padding(4);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(100, 28);
            this.Output.TabIndex = 39;
            this.Output.Text = "Вывод";
            this.Output.UseVisualStyleBackColor = true;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // SemestrValue
            // 
            this.SemestrValue.FormattingEnabled = true;
            this.SemestrValue.Items.AddRange(new object[] {
            "1",
            "2"});
            this.SemestrValue.Location = new System.Drawing.Point(344, 128);
            this.SemestrValue.Margin = new System.Windows.Forms.Padding(4);
            this.SemestrValue.Name = "SemestrValue";
            this.SemestrValue.Size = new System.Drawing.Size(52, 24);
            this.SemestrValue.TabIndex = 42;
            // 
            // SemestrLabel
            // 
            this.SemestrLabel.AutoSize = true;
            this.SemestrLabel.Location = new System.Drawing.Point(264, 133);
            this.SemestrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SemestrLabel.Name = "SemestrLabel";
            this.SemestrLabel.Size = new System.Drawing.Size(68, 17);
            this.SemestrLabel.TabIndex = 41;
            this.SemestrLabel.Text = "Семестр:";
            // 
            // CouseLabel
            // 
            this.CouseLabel.AutoSize = true;
            this.CouseLabel.Location = new System.Drawing.Point(421, 133);
            this.CouseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CouseLabel.Name = "CouseLabel";
            this.CouseLabel.Size = new System.Drawing.Size(43, 17);
            this.CouseLabel.TabIndex = 44;
            this.CouseLabel.Text = "Курс:";
            // 
            // CourseValue
            // 
            this.CourseValue.Location = new System.Drawing.Point(474, 129);
            this.CourseValue.Margin = new System.Windows.Forms.Padding(4);
            this.CourseValue.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.CourseValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CourseValue.Name = "CourseValue";
            this.CourseValue.Size = new System.Drawing.Size(36, 22);
            this.CourseValue.TabIndex = 43;
            this.CourseValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SpecializationDEVI
            // 
            this.SpecializationDEVI.AutoSize = true;
            this.SpecializationDEVI.Location = new System.Drawing.Point(447, 176);
            this.SpecializationDEVI.Margin = new System.Windows.Forms.Padding(4);
            this.SpecializationDEVI.Name = "SpecializationDEVI";
            this.SpecializationDEVI.Size = new System.Drawing.Size(69, 21);
            this.SpecializationDEVI.TabIndex = 49;
            this.SpecializationDEVI.Text = "ДЭВИ";
            this.SpecializationDEVI.UseVisualStyleBackColor = true;
            // 
            // SpecializationISIT
            // 
            this.SpecializationISIT.AutoSize = true;
            this.SpecializationISIT.Location = new System.Drawing.Point(364, 176);
            this.SpecializationISIT.Margin = new System.Windows.Forms.Padding(4);
            this.SpecializationISIT.Name = "SpecializationISIT";
            this.SpecializationISIT.Size = new System.Drawing.Size(68, 21);
            this.SpecializationISIT.TabIndex = 48;
            this.SpecializationISIT.Text = "ИСИТ";
            this.SpecializationISIT.UseVisualStyleBackColor = true;
            // 
            // SpecializationPOIBMS
            // 
            this.SpecializationPOIBMS.AutoSize = true;
            this.SpecializationPOIBMS.Location = new System.Drawing.Point(259, 176);
            this.SpecializationPOIBMS.Margin = new System.Windows.Forms.Padding(4);
            this.SpecializationPOIBMS.Name = "SpecializationPOIBMS";
            this.SpecializationPOIBMS.Size = new System.Drawing.Size(90, 21);
            this.SpecializationPOIBMS.TabIndex = 47;
            this.SpecializationPOIBMS.Text = "ПОИБМС";
            this.SpecializationPOIBMS.UseVisualStyleBackColor = true;
            // 
            // SpecializationPOIT
            // 
            this.SpecializationPOIT.AutoSize = true;
            this.SpecializationPOIT.Location = new System.Drawing.Point(175, 176);
            this.SpecializationPOIT.Margin = new System.Windows.Forms.Padding(4);
            this.SpecializationPOIT.Name = "SpecializationPOIT";
            this.SpecializationPOIT.Size = new System.Drawing.Size(70, 21);
            this.SpecializationPOIT.TabIndex = 46;
            this.SpecializationPOIT.Text = "ПОИТ";
            this.SpecializationPOIT.UseVisualStyleBackColor = true;
            // 
            // Specialization
            // 
            this.Specialization.AutoSize = true;
            this.Specialization.Location = new System.Drawing.Point(49, 178);
            this.Specialization.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Specialization.Name = "Specialization";
            this.Specialization.Size = new System.Drawing.Size(113, 17);
            this.Specialization.TabIndex = 45;
            this.Specialization.Text = "Специальность:";
            // 
            // LabsCountValue
            // 
            this.LabsCountValue.AutoSize = true;
            this.LabsCountValue.Location = new System.Drawing.Point(506, 285);
            this.LabsCountValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabsCountValue.Name = "LabsCountValue";
            this.LabsCountValue.Size = new System.Drawing.Size(0, 17);
            this.LabsCountValue.TabIndex = 55;
            // 
            // LabsCountLabel
            // 
            this.LabsCountLabel.AutoSize = true;
            this.LabsCountLabel.Location = new System.Drawing.Point(33, 285);
            this.LabsCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabsCountLabel.Name = "LabsCountLabel";
            this.LabsCountLabel.Size = new System.Drawing.Size(189, 17);
            this.LabsCountLabel.TabIndex = 54;
            this.LabsCountLabel.Text = "Количество лабораторных:";
            // 
            // LabsCount
            // 
            this.LabsCount.Location = new System.Drawing.Point(233, 285);
            this.LabsCount.Margin = new System.Windows.Forms.Padding(4);
            this.LabsCount.Maximum = 32;
            this.LabsCount.Minimum = 10;
            this.LabsCount.Name = "LabsCount";
            this.LabsCount.Size = new System.Drawing.Size(273, 56);
            this.LabsCount.TabIndex = 53;
            this.LabsCount.Value = 10;
            this.LabsCount.ValueChanged += new System.EventHandler(this.LabsCount_ValueChanged);
            // 
            // LecturesCountValue
            // 
            this.LecturesCountValue.AutoSize = true;
            this.LecturesCountValue.Location = new System.Drawing.Point(506, 222);
            this.LecturesCountValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LecturesCountValue.Name = "LecturesCountValue";
            this.LecturesCountValue.Size = new System.Drawing.Size(0, 17);
            this.LecturesCountValue.TabIndex = 52;
            // 
            // LecturesCountLabel
            // 
            this.LecturesCountLabel.AutoSize = true;
            this.LecturesCountLabel.Location = new System.Drawing.Point(81, 222);
            this.LecturesCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LecturesCountLabel.Name = "LecturesCountLabel";
            this.LecturesCountLabel.Size = new System.Drawing.Size(141, 17);
            this.LecturesCountLabel.TabIndex = 51;
            this.LecturesCountLabel.Text = "Количество лекций:";
            // 
            // LecturesCount
            // 
            this.LecturesCount.Location = new System.Drawing.Point(233, 222);
            this.LecturesCount.Margin = new System.Windows.Forms.Padding(4);
            this.LecturesCount.Maximum = 32;
            this.LecturesCount.Minimum = 10;
            this.LecturesCount.Name = "LecturesCount";
            this.LecturesCount.Size = new System.Drawing.Size(273, 56);
            this.LecturesCount.TabIndex = 50;
            this.LecturesCount.Value = 10;
            this.LecturesCount.ValueChanged += new System.EventHandler(this.LecturesCount_ValueChanged);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(101, 10);
            this.test.Margin = new System.Windows.Forms.Padding(4);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(67, 21);
            this.test.TabIndex = 58;
            this.test.TabStop = true;
            this.test.Text = "зачёт";
            this.test.UseVisualStyleBackColor = true;
            // 
            // exam
            // 
            this.exam.AutoSize = true;
            this.exam.Location = new System.Drawing.Point(4, 10);
            this.exam.Margin = new System.Windows.Forms.Padding(4);
            this.exam.Name = "exam";
            this.exam.Size = new System.Drawing.Size(83, 21);
            this.exam.TabIndex = 57;
            this.exam.TabStop = true;
            this.exam.Text = "экзамен";
            this.exam.UseVisualStyleBackColor = true;
            // 
            // DisciplineControl
            // 
            this.DisciplineControl.AutoSize = true;
            this.DisciplineControl.Location = new System.Drawing.Point(123, 360);
            this.DisciplineControl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DisciplineControl.Name = "DisciplineControl";
            this.DisciplineControl.Size = new System.Drawing.Size(103, 17);
            this.DisciplineControl.TabIndex = 56;
            this.DisciplineControl.Text = "Вид контроля:";
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.exam);
            this.ControlPanel.Controls.Add(this.test);
            this.ControlPanel.Location = new System.Drawing.Point(233, 348);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(172, 39);
            this.ControlPanel.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(452, 420);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "-";
            // 
            // CorpusAydit
            // 
            this.CorpusAydit.Location = new System.Drawing.Point(472, 419);
            this.CorpusAydit.Margin = new System.Windows.Forms.Padding(4);
            this.CorpusAydit.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.CorpusAydit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CorpusAydit.Name = "CorpusAydit";
            this.CorpusAydit.Size = new System.Drawing.Size(35, 22);
            this.CorpusAydit.TabIndex = 64;
            this.CorpusAydit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumberAudit
            // 
            this.NumberAudit.Location = new System.Drawing.Point(392, 419);
            this.NumberAudit.Margin = new System.Windows.Forms.Padding(4);
            this.NumberAudit.Maximum = new decimal(new int[] {
            430,
            0,
            0,
            0});
            this.NumberAudit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumberAudit.Name = "NumberAudit";
            this.NumberAudit.Size = new System.Drawing.Size(56, 22);
            this.NumberAudit.TabIndex = 63;
            this.NumberAudit.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // SNP
            // 
            this.SNP.Location = new System.Drawing.Point(84, 418);
            this.SNP.Margin = new System.Windows.Forms.Padding(4);
            this.SNP.Name = "SNP";
            this.SNP.Size = new System.Drawing.Size(273, 22);
            this.SNP.TabIndex = 62;
            this.SNP.Text = "Ф.И.О.";
            this.SNP.Enter += new System.EventHandler(this.SNP_Enter);
            this.SNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SNP_KeyPress);
            // 
            // Pulpit
            // 
            this.Pulpit.Location = new System.Drawing.Point(84, 450);
            this.Pulpit.Margin = new System.Windows.Forms.Padding(4);
            this.Pulpit.Name = "Pulpit";
            this.Pulpit.Size = new System.Drawing.Size(396, 22);
            this.Pulpit.TabIndex = 61;
            this.Pulpit.Text = "Кафедра";
            this.Pulpit.Enter += new System.EventHandler(this.Pulpit_Enter);
            // 
            // Lector
            // 
            this.Lector.AutoSize = true;
            this.Lector.Location = new System.Drawing.Point(8, 439);
            this.Lector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lector.Name = "Lector";
            this.Lector.Size = new System.Drawing.Size(60, 17);
            this.Lector.TabIndex = 60;
            this.Lector.Text = "Лектор:";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(35, 528);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(88, 33);
            this.Add.TabIndex = 71;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // BookList
            // 
            this.BookList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.BookList.AutoArrange = false;
            this.BookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookList.GridLines = true;
            this.BookList.HideSelection = false;
            this.BookList.Location = new System.Drawing.Point(35, 567);
            this.BookList.Margin = new System.Windows.Forms.Padding(4);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(488, 88);
            this.BookList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.BookList.TabIndex = 70;
            this.BookList.UseCompatibleStateImageBehavior = false;
            this.BookList.View = System.Windows.Forms.View.List;
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(135, 535);
            this.BookName.Margin = new System.Windows.Forms.Padding(4);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(385, 22);
            this.BookName.TabIndex = 69;
            this.BookName.Text = "Название";
            this.BookName.Enter += new System.EventHandler(this.BookName_Enter);
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(135, 503);
            this.Author.Margin = new System.Windows.Forms.Padding(4);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(245, 22);
            this.Author.TabIndex = 68;
            this.Author.Text = "Автор";
            this.Author.Enter += new System.EventHandler(this.Author_Enter);
            // 
            // CreationDate
            // 
            this.CreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreationDate.Location = new System.Drawing.Point(390, 503);
            this.CreationDate.Margin = new System.Windows.Forms.Padding(4);
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Size = new System.Drawing.Size(131, 22);
            this.CreationDate.TabIndex = 67;
            this.CreationDate.Value = new System.DateTime(1923, 1, 1, 0, 0, 0, 0);
            // 
            // Literature
            // 
            this.Literature.AutoSize = true;
            this.Literature.Location = new System.Drawing.Point(31, 507);
            this.Literature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Literature.Name = "Literature";
            this.Literature.Size = new System.Drawing.Size(91, 17);
            this.Literature.TabIndex = 66;
            this.Literature.Text = "Литература:";
            // 
            // OutputList
            // 
            this.OutputList.Location = new System.Drawing.Point(535, 116);
            this.OutputList.Margin = new System.Windows.Forms.Padding(4);
            this.OutputList.Name = "OutputList";
            this.OutputList.Size = new System.Drawing.Size(513, 522);
            this.OutputList.TabIndex = 72;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Search,
            this.Sort,
            this.Save,
            this.About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 28);
            this.menuStrip1.TabIndex = 73;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Search
            // 
            this.Search.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LectorSearch,
            this.SemestrSearch,
            this.CourseSearch});
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(66, 24);
            this.Search.Text = "Поиск";
            // 
            // LectorSearch
            // 
            this.LectorSearch.Name = "LectorSearch";
            this.LectorSearch.Size = new System.Drawing.Size(179, 26);
            this.LectorSearch.Text = "По лектору";
            this.LectorSearch.Click += new System.EventHandler(this.LectorSearch_Click);
            // 
            // SemestrSearch
            // 
            this.SemestrSearch.Name = "SemestrSearch";
            this.SemestrSearch.Size = new System.Drawing.Size(179, 26);
            this.SemestrSearch.Text = "По семестру";
            this.SemestrSearch.Click += new System.EventHandler(this.SemestrSearch_Click);
            // 
            // CourseSearch
            // 
            this.CourseSearch.Name = "CourseSearch";
            this.CourseSearch.Size = new System.Drawing.Size(179, 26);
            this.CourseSearch.Text = "По курсу";
            this.CourseSearch.Click += new System.EventHandler(this.CourseSearch_Click);
            // 
            // Sort
            // 
            this.Sort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LecturesSort,
            this.PassTypeSort});
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(135, 24);
            this.Sort.Text = "Сортировать по";
            // 
            // LecturesSort
            // 
            this.LecturesSort.Name = "LecturesSort";
            this.LecturesSort.Size = new System.Drawing.Size(225, 26);
            this.LecturesSort.Text = "Количеству лекций";
            this.LecturesSort.Click += new System.EventHandler(this.LecturesSort_Click);
            // 
            // PassTypeSort
            // 
            this.PassTypeSort.Name = "PassTypeSort";
            this.PassTypeSort.Size = new System.Drawing.Size(225, 26);
            this.PassTypeSort.Text = "Виду контроля";
            this.PassTypeSort.Click += new System.EventHandler(this.PassTypeSort_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(97, 24);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(118, 24);
            this.About.Text = "О программе";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Example1
            // 
            this.Example1.Location = new System.Drawing.Point(13, 354);
            this.Example1.Margin = new System.Windows.Forms.Padding(4);
            this.Example1.Name = "Example1";
            this.Example1.Size = new System.Drawing.Size(35, 28);
            this.Example1.TabIndex = 74;
            this.Example1.Text = "1";
            this.Example1.UseVisualStyleBackColor = true;
            this.Example1.Click += new System.EventHandler(this.Example1_Click);
            // 
            // fixTool
            // 
            this.fixTool.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fixTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchTool,
            this.SortTool,
            this.SaveTool,
            this.AboutTool,
            this.toolStripSeparator1,
            this.fastentool});
            this.fixTool.Location = new System.Drawing.Point(0, 28);
            this.fixTool.Name = "fixTool";
            this.fixTool.Size = new System.Drawing.Size(1056, 27);
            this.fixTool.TabIndex = 75;
            this.fixTool.Text = "toolStrip1";
            // 
            // SearchTool
            // 
            this.SearchTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LectorSearchTool,
            this.SemestrSearcheTool,
            this.CourseSearchTool});
            this.SearchTool.Image = ((System.Drawing.Image)(resources.GetObject("SearchTool.Image")));
            this.SearchTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchTool.Name = "SearchTool";
            this.SearchTool.Size = new System.Drawing.Size(34, 24);
            this.SearchTool.Text = "Поиск";
            // 
            // LectorSearchTool
            // 
            this.LectorSearchTool.Name = "LectorSearchTool";
            this.LectorSearchTool.Size = new System.Drawing.Size(179, 26);
            this.LectorSearchTool.Text = "По лектору";
            this.LectorSearchTool.Click += new System.EventHandler(this.LectorSearch_Click);
            // 
            // SemestrSearcheTool
            // 
            this.SemestrSearcheTool.Name = "SemestrSearcheTool";
            this.SemestrSearcheTool.Size = new System.Drawing.Size(179, 26);
            this.SemestrSearcheTool.Text = "По семестру";
            this.SemestrSearcheTool.Click += new System.EventHandler(this.SemestrSearch_Click);
            // 
            // CourseSearchTool
            // 
            this.CourseSearchTool.Name = "CourseSearchTool";
            this.CourseSearchTool.Size = new System.Drawing.Size(179, 26);
            this.CourseSearchTool.Text = "По курсу";
            this.CourseSearchTool.Click += new System.EventHandler(this.CourseSearch_Click);
            // 
            // SortTool
            // 
            this.SortTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SortTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.PassTypeSortTool});
            this.SortTool.Image = ((System.Drawing.Image)(resources.GetObject("SortTool.Image")));
            this.SortTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortTool.Name = "SortTool";
            this.SortTool.Size = new System.Drawing.Size(34, 24);
            this.SortTool.Text = "Сортировать по";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(225, 26);
            this.toolStripMenuItem2.Text = "Количеству лекций";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.LecturesSort_Click);
            // 
            // PassTypeSortTool
            // 
            this.PassTypeSortTool.Name = "PassTypeSortTool";
            this.PassTypeSortTool.Size = new System.Drawing.Size(225, 26);
            this.PassTypeSortTool.Text = "Виду контроля";
            this.PassTypeSortTool.Click += new System.EventHandler(this.PassTypeSort_Click);
            // 
            // SaveTool
            // 
            this.SaveTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveTool.Image = ((System.Drawing.Image)(resources.GetObject("SaveTool.Image")));
            this.SaveTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveTool.Name = "SaveTool";
            this.SaveTool.Size = new System.Drawing.Size(29, 24);
            this.SaveTool.Text = "Сохранить";
            this.SaveTool.Click += new System.EventHandler(this.Save_Click);
            // 
            // AboutTool
            // 
            this.AboutTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutTool.Image = ((System.Drawing.Image)(resources.GetObject("AboutTool.Image")));
            this.AboutTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutTool.Name = "AboutTool";
            this.AboutTool.Size = new System.Drawing.Size(29, 24);
            this.AboutTool.Text = "О программе";
            this.AboutTool.Click += new System.EventHandler(this.About_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // fastentool
            // 
            this.fastentool.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fastentool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fastentool.Image = ((System.Drawing.Image)(resources.GetObject("fastentool.Image")));
            this.fastentool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fastentool.Name = "fastentool";
            this.fastentool.Size = new System.Drawing.Size(29, 24);
            this.fastentool.Text = "toolStripButton1";
            this.fastentool.Click += new System.EventHandler(this.fixTool_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountOfObjectLabel,
            this.CountOfObject,
            this.LastActionLabel,
            this.LastAction,
            this.DataTime,
            this.DateTimeChange});
            this.statusStrip1.Location = new System.Drawing.Point(0, 681);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1056, 26);
            this.statusStrip1.TabIndex = 76;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CountOfObjectLabel
            // 
            this.CountOfObjectLabel.Name = "CountOfObjectLabel";
            this.CountOfObjectLabel.Size = new System.Drawing.Size(162, 20);
            this.CountOfObjectLabel.Text = "Количество объектов:";
            // 
            // CountOfObject
            // 
            this.CountOfObject.Name = "CountOfObject";
            this.CountOfObject.Size = new System.Drawing.Size(17, 20);
            this.CountOfObject.Text = "1";
            // 
            // LastActionLabel
            // 
            this.LastActionLabel.Name = "LastActionLabel";
            this.LastActionLabel.Size = new System.Drawing.Size(155, 20);
            this.LastActionLabel.Text = "Последнее действие:";
            // 
            // LastAction
            // 
            this.LastAction.Name = "LastAction";
            this.LastAction.Size = new System.Drawing.Size(95, 20);
            this.LastAction.Text = "Добавление";
            // 
            // DataTime
            // 
            this.DataTime.Name = "DataTime";
            this.DataTime.Size = new System.Drawing.Size(105, 20);
            this.DataTime.Text = "Дата и время:";
            // 
            // DateTimeChange
            // 
            this.DateTimeChange.Name = "DateTimeChange";
            this.DateTimeChange.Size = new System.Drawing.Size(54, 20);
            this.DateTimeChange.Text = "Время";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 707);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.fixTool);
            this.Controls.Add(this.Example1);
            this.Controls.Add(this.OutputList);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.BookList);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.CreationDate);
            this.Controls.Add(this.Literature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CorpusAydit);
            this.Controls.Add(this.NumberAudit);
            this.Controls.Add(this.SNP);
            this.Controls.Add(this.Pulpit);
            this.Controls.Add(this.Lector);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.DisciplineControl);
            this.Controls.Add(this.LabsCountValue);
            this.Controls.Add(this.LabsCountLabel);
            this.Controls.Add(this.LabsCount);
            this.Controls.Add(this.LecturesCountValue);
            this.Controls.Add(this.LecturesCountLabel);
            this.Controls.Add(this.LecturesCount);
            this.Controls.Add(this.SpecializationDEVI);
            this.Controls.Add(this.SpecializationISIT);
            this.Controls.Add(this.SpecializationPOIBMS);
            this.Controls.Add(this.SpecializationPOIT);
            this.Controls.Add(this.Specialization);
            this.Controls.Add(this.CouseLabel);
            this.Controls.Add(this.CourseValue);
            this.Controls.Add(this.SemestrValue);
            this.Controls.Add(this.SemestrLabel);
            this.Controls.Add(this.AddAll);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.DisciplineName);
            this.Controls.Add(this.DisciplineLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторная 5-6";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CourseValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturesCount)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CorpusAydit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberAudit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.fixTool.ResumeLayout(false);
            this.fixTool.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisciplineName;
        private System.Windows.Forms.Label DisciplineLabel;
        private System.Windows.Forms.Button AddAll;
        private System.Windows.Forms.Button Output;
        private System.Windows.Forms.ComboBox SemestrValue;
        private System.Windows.Forms.Label SemestrLabel;
        private System.Windows.Forms.Label CouseLabel;
        private System.Windows.Forms.NumericUpDown CourseValue;
        private System.Windows.Forms.CheckBox SpecializationDEVI;
        private System.Windows.Forms.CheckBox SpecializationISIT;
        private System.Windows.Forms.CheckBox SpecializationPOIBMS;
        private System.Windows.Forms.CheckBox SpecializationPOIT;
        private System.Windows.Forms.Label Specialization;
        private System.Windows.Forms.Label LabsCountValue;
        private System.Windows.Forms.Label LabsCountLabel;
        private System.Windows.Forms.TrackBar LabsCount;
        private System.Windows.Forms.Label LecturesCountValue;
        private System.Windows.Forms.Label LecturesCountLabel;
        private System.Windows.Forms.TrackBar LecturesCount;
        private System.Windows.Forms.RadioButton test;
        private System.Windows.Forms.RadioButton exam;
        private System.Windows.Forms.Label DisciplineControl;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CorpusAydit;
        private System.Windows.Forms.NumericUpDown NumberAudit;
        private System.Windows.Forms.TextBox SNP;
        private System.Windows.Forms.TextBox Pulpit;
        private System.Windows.Forms.Label Lector;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListView BookList;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.DateTimePicker CreationDate;
        private System.Windows.Forms.Label Literature;
        private System.Windows.Forms.TreeView OutputList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Search;
        private System.Windows.Forms.ToolStripMenuItem LectorSearch;
        private System.Windows.Forms.ToolStripMenuItem SemestrSearch;
        private System.Windows.Forms.ToolStripMenuItem CourseSearch;
        private System.Windows.Forms.ToolStripMenuItem Sort;
        private System.Windows.Forms.ToolStripMenuItem LecturesSort;
        private System.Windows.Forms.ToolStripMenuItem PassTypeSort;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.Button Example1;
        private System.Windows.Forms.ToolStrip fixTool;
        private System.Windows.Forms.ToolStripButton SaveTool;
        private System.Windows.Forms.ToolStripButton AboutTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton fastentool;
        private System.Windows.Forms.ToolStripDropDownButton SearchTool;
        private System.Windows.Forms.ToolStripMenuItem LectorSearchTool;
        private System.Windows.Forms.ToolStripMenuItem SemestrSearcheTool;
        private System.Windows.Forms.ToolStripMenuItem CourseSearchTool;
        private System.Windows.Forms.ToolStripDropDownButton SortTool;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem PassTypeSortTool;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CountOfObjectLabel;
        private System.Windows.Forms.ToolStripStatusLabel CountOfObject;
        private System.Windows.Forms.ToolStripStatusLabel LastActionLabel;
        private System.Windows.Forms.ToolStripStatusLabel LastAction;
        private System.Windows.Forms.ToolStripStatusLabel DataTime;
        private System.Windows.Forms.ToolStripStatusLabel DateTimeChange;
    }
}

