﻿using ClosedXML.Excel;
using Microsoft.Office.Interop.Excel;
using StudyManagementApp.FlashCardFolder;
using StudyManagementApp.NoteFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace StudyManagementApp
{
    public partial class NoteExportForm : Form
    {
        public  NoteExportForm()
        {
            InitializeComponent();
        }

        private void NoteExportButton_Click(object sender, EventArgs e)
        {
       
            var lines = new List<string>();
            string[] columnNames;
            if (WorkPlace.bang_ALLNOTES != null)
            {
                columnNames = WorkPlace.bang_ALLNOTES.Columns
                .Cast<DataColumn>()
                .Select(column => column.ColumnName)
                .ToArray();
            }
            else
            {
                CustomMessageBox mssBox = new CustomMessageBox("Error", "You have no Note to export");
                mssBox.ShowDialog();
                return;
            }

            var header = string.Join(",", columnNames.Select(name => $"\"{name}\""));
            lines.Add(header);


            var valueLines = WorkPlace.bang_ALLNOTES.AsEnumerable()
                .Select(row => string.Join(",", row.ItemArray.Select(val => $"\"{val}\"")));

            string ExcelFilePath = "";
            lines.AddRange(valueLines);

            SaveFileDialog open = new SaveFileDialog();
            open.Filter = "xml files (*.xls)|*.xls|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ExcelFilePath = open.FileName;
                File.WriteAllLines(ExcelFilePath, lines, Encoding.UTF8);
                InformSuccess inform = new InformSuccess();
                inform.ShowDialog();
            }

            if (open.FileName == "")
                ExcelFilePath = "No name";

        }
    }
}
