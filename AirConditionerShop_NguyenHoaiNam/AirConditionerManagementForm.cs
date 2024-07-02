using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirConditionerShop_NguyenHoaiNam.DTOs;
using Services;

namespace AirConditionerShop_NguyenHoaiNam
{
    public partial class AirConditionerManagementForm : Form
    {
        private AirConditionerService _airConditionerService = new();
        private SupplierCompanyService _supplierCompanyService = new();
        private AirConditionerDTO _selectedAirConditionerDTO = null;
        private bool isClosingConfirmed = false;

        public AirConditionerManagementForm()
        {
            InitializeComponent();
        }

        private List<AirConditionerDTO> GetAllAirConditionerDTOs()
        {
            var airConditionerList = _airConditionerService.GetAllAirConditioners();
            var supplierList = _supplierCompanyService.GetAllSupplierCompany();
            var airConditionerDTOList = new List<AirConditionerDTO>();
            foreach (var a in airConditionerList)
            {
                foreach (var s in supplierList)
                {
                    if (a.SupplierId == s.SupplierId)
                    {
                        airConditionerDTOList.Add(new AirConditionerDTO()
                        {
                            AirConditionerId = a.AirConditionerId,
                            AirConditionerName = a.AirConditionerName,
                            Warranty = a.Warranty,
                            SoundPressureLevel = a.SoundPressureLevel,
                            FeatureFunction = a.FeatureFunction,
                            Quantity = a.Quantity,
                            DollarPrice = a.DollarPrice,
                            SupplierId = a.SupplierId,
                            SupplierName = s.SupplierName,
                        });
                    }
                }
            }
            return airConditionerDTOList;
        }

        private void FillDataGridView()
        {
            dgvAirConditionerList.DataSource = null;
            dgvAirConditionerList.DataSource = GetAllAirConditionerDTOs();
        }

        private void AirConditionerManagementForm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvAirConditionerList.DataSource = GetAllAirConditionerDTOs().Where(a =>
            a.AirConditionerName.ToLower().Contains(txtName.Text.Trim().ToLower()) &&
            a.FeatureFunction.ToLower().Contains(txtFeature.Text.Trim().ToLower())).ToList();
        }

        private void dgvAirConditionerList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAirConditionerList.SelectedRows.Count > 0)
            {
                _selectedAirConditionerDTO = (AirConditionerDTO)dgvAirConditionerList.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAirConditionerList.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Air conditioner selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Do you really want to delete this air conditioner", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            var airConditioner = _airConditionerService.GetAirConditioner(_selectedAirConditionerDTO.AirConditionerId);
            _airConditionerService.DeleteAirConditioner(airConditioner);
            FillDataGridView();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AirConditionerDetailForm form = new();
            form.ShowDialog();
            FillDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAirConditionerList.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Air conditioner selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AirConditionerDetailForm form = new();
            form.SelectedAirConditioner = _airConditionerService.GetAirConditioner(_selectedAirConditionerDTO.AirConditionerId);
            form.ShowDialog();
            FillDataGridView();
        }

        private void ConfirmExit()
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                isClosingConfirmed = true;
                Application.ExitThread();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ConfirmExit();
        }

        private void AirConditionerManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClosingConfirmed)
            {
                e.Cancel = true;
                ConfirmExit();
            }
        }
    }
}
