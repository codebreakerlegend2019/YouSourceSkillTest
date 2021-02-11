using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouSourceSkillTest.Controllers;
using YouSourceSkillTest.Enumerations;
using YouSourceSkillTest.Models;

namespace YouSourceSkillTest.Views
{
    public partial class SortForm : Form
    {
        private SortController _sortController = new SortController();
        public SortForm()
        {
            InitializeComponent();
            cb_sortingStrategy.DataSource = Enum.GetValues(typeof(SortStrategy));
        }

        private void btn_doSort_Click(object sender, EventArgs e)
        {
            var sortDto = new SortDto()
            {
                TextToSort = tb_textToSort.Text,
                SortStrategy = (SortStrategy)cb_sortingStrategy.SelectedItem
            };
            var sortResult = _sortController.SortText(sortDto);
            if (sortResult.IsSuccessful)
                lbl_sorted_text.Text = sortResult.Result;
            else
                MessageBox.Show(sortResult.ErrorMessage);
        }
    }
}
