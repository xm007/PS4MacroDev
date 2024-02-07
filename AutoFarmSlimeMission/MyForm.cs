using System;
using System.Windows.Forms;

namespace AutoFarmSlimeMission
{
    public class MyForm : Form
    {
        private CheckBox checkBoxCagliostro;
        private CheckBox checkBoxEugen;

        public MyForm()
        {

            // 初始化卡莉奥斯特罗复选框
            checkBoxCagliostro = new CheckBox
            {
                Text = "卡莉奥斯特罗",
                AutoSize = true,
                Location = new System.Drawing.Point(10, 10)
            };
            checkBoxCagliostro.CheckedChanged += CheckBoxCagliostro_CheckedChanged;

            // 初始化欧根复选框
            checkBoxEugen = new CheckBox
            {
                Text = "欧根",
                AutoSize = true,
                Location = new System.Drawing.Point(10, 40)
            };
            checkBoxEugen.CheckedChanged += CheckBoxEugen_CheckedChanged;

            // 将复选框添加到窗体的控件集合中
            Controls.Add(checkBoxCagliostro);
            Controls.Add(checkBoxEugen);
        }

        private void CheckBoxCagliostro_CheckedChanged(object sender, EventArgs e)
        {
            // 更新IsCagliostro属性
            MainScript.IsCagliostro = checkBoxCagliostro.Checked;
        }

        private void CheckBoxEugen_CheckedChanged(object sender, EventArgs e)
        {
            // 更新IsEugen属性
            MainScript.IsEugen = checkBoxEugen.Checked;
        }
    }
}