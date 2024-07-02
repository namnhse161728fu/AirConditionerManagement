using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories.Models;
using Services;

namespace AirConditionerShop_NguyenHoaiNam
{
    public partial class AirConditionerDetailForm : Form
    {
        private AirConditionerService _airConditionerService = new();
        private SupplierCompanyService _supplierCompanyService = new();
        public AirConditioner SelectedAirConditioner { get; set; }
        private ErrorProvider _errorProvider = new();
        private bool _isFormValid = true;
        public AirConditionerDetailForm()
        {
            InitializeComponent();
            SelectedAirConditioner = null;
        }

        private void AirConditionerDetailForm_Load(object sender, EventArgs e)
        {
            cboSupplier.DataSource = _supplierCompanyService.GetAllSupplierCompany();

            cboSupplier.DisplayMember = "SupplierName";

            cboSupplier.ValueMember = "SupplierId";

            if (SelectedAirConditioner == null)
            {
                lblHeader.Text = "Create Air Conditioner";
            }
            else
            {
                lblHeader.Text = "Update Air Conditioner";
                txtAirConditionerId.Text = SelectedAirConditioner.AirConditionerId.ToString();
                txtAirConditionerId.Enabled = false;
                txtAirConditionerName.Text = SelectedAirConditioner.AirConditionerName;
                txtWarranty.Text = SelectedAirConditioner.Warranty;
                txtSoundPressureLevel.Text = SelectedAirConditioner.SoundPressureLevel;
                txtFeatureFunction.Text = SelectedAirConditioner.FeatureFunction;
                txtQuantity.Text = SelectedAirConditioner.Quantity.ToString();
                txtDollarPrice.Text = SelectedAirConditioner.DollarPrice.ToString();
                cboSupplier.SelectedValue = SelectedAirConditioner.SupplierId;
            }
        }

        private void txtAirConditionerId_Validating(object sender, CancelEventArgs e)
        {
            var airConditionerId = txtAirConditionerId.Text.Trim();
            if (string.IsNullOrEmpty(airConditionerId))
            {
                _errorProvider.SetError(txtAirConditionerId, "Air Conditioner Id must not be empty");
                _isFormValid = false;
            }
            else
            {
                if (!(int.TryParse(airConditionerId, out _) && int.Parse(airConditionerId) > 0))
                {
                    _errorProvider.SetError(txtAirConditionerId, "Air Conditioner Id must be integer and greater than 0");
                    _isFormValid = false;
                }
                else
                {
                    var airConditioner = _airConditionerService.GetAirConditioner(int.Parse(airConditionerId));
                    if (airConditioner != null)
                    {
                        _errorProvider.SetError(txtAirConditionerId, "Duplicated Air Conditioner Id");
                        _isFormValid = false;
                    }
                }
            }
        }

        private void txtAirConditionerName_Validating(object sender, CancelEventArgs e)
        {
            var airConditionerName = txtAirConditionerName.Text.Trim();
            if (string.IsNullOrEmpty(airConditionerName))
            {
                _errorProvider.SetError(txtAirConditionerName, "Air Conditioner Name must not be empty");
                _isFormValid = false;
            }
        }

        private void txtWarranty_Validating(object sender, CancelEventArgs e)
        {
            var warranty = txtWarranty.Text.Trim();
            if (string.IsNullOrEmpty(warranty))
            {
                _errorProvider.SetError(txtWarranty, "Warranty must not be empty");
                _isFormValid = false;
            }
            else
            {
                var number = warranty.Substring(0, 1);
                if (!(int.TryParse(number, out _) && int.Parse(number) > 0))
                {
                    _errorProvider.SetError(txtWarranty, "Warranty must be integer and greater than 0");
                    _isFormValid = false;
                }
            }
        }

        private void txtSoundPressureLevel_Validating(object sender, CancelEventArgs e)
        {
            var soundPressureLevel = txtSoundPressureLevel.Text.Trim();
            if (string.IsNullOrEmpty(soundPressureLevel))
            {
                _errorProvider.SetError(txtSoundPressureLevel, "Sound Pressure Level must not be empty");
                _isFormValid = false;
            }
            else
            {
                bool isDigitExist = false;
                foreach (var c in soundPressureLevel)
                {
                    if (Char.IsDigit(c))
                    {
                        isDigitExist = true;
                        break;
                    }
                }
                if (!isDigitExist)
                {
                    _errorProvider.SetError(txtSoundPressureLevel, "Sound Pressure Level must contain number");
                    _isFormValid = false;
                }
            }
        }

        private void txtFeatureFunction_Validating(object sender, CancelEventArgs e)
        {
            var featureFunction = txtFeatureFunction.Text.Trim();
            if (string.IsNullOrEmpty(featureFunction))
            {
                _errorProvider.SetError(txtFeatureFunction, "Feature Function must not be empty");
                _isFormValid = false;
            }
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            var quantity = txtQuantity.Text.Trim();
            if (string.IsNullOrEmpty(quantity))
            {
                _errorProvider.SetError(txtQuantity, "Quantity must not be empty");
                _isFormValid = false;
            }
            else
            {
                if (!(int.TryParse(quantity, out _) && int.Parse(quantity) >= 0))
                {
                    _errorProvider.SetError(txtQuantity, "Quantity must be natual numbers");
                    _isFormValid = false;
                }
            }
        }

        private void txtDollarPrice_Validating(object sender, CancelEventArgs e)
        {
            var dollarPrice = txtDollarPrice.Text.Trim();
            if (string.IsNullOrEmpty(dollarPrice))
            {
                _errorProvider.SetError(txtDollarPrice, "Dollar Price must not be empty");
                _isFormValid = false;
            }
            else
            {
                if (!(double.TryParse(dollarPrice, out _) && double.Parse(dollarPrice) > 0))
                {
                    _errorProvider.SetError(txtQuantity, "Quantity must be greater than 0");
                    _isFormValid = false;
                }
            }
        }

        private void txtAirConditionerId_TextChanged(object sender, EventArgs e)
        {
            _isFormValid = true;
            _errorProvider.SetError(txtAirConditionerId, "");
        }

        private void txtAirConditionerName_TextChanged(object sender, EventArgs e)
        {
            _isFormValid = true;
            _errorProvider.SetError(txtAirConditionerName, "");
        }

        private void txtWarranty_TextChanged(object sender, EventArgs e)
        {
            _isFormValid = true;
            _errorProvider.SetError(txtWarranty, "");
        }

        private void txtSoundPressureLevel_TextChanged(object sender, EventArgs e)
        {
            _isFormValid = true;
            _errorProvider.SetError(txtSoundPressureLevel, "");
        }

        private void txtFeatureFunction_TextChanged(object sender, EventArgs e)
        {
            _isFormValid = true;
            _errorProvider.SetError(txtFeatureFunction, "");
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            _isFormValid = true;
            _errorProvider.SetError(txtQuantity, "");
        }

        private void txtDollarPrice_TextChanged(object sender, EventArgs e)
        {
            _isFormValid = true;
            _errorProvider.SetError(txtDollarPrice, "");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_isFormValid == false)
            {
                MessageBox.Show("Fail to save, plese check information again!", "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var airConditioner = new AirConditioner()
            {
                AirConditionerId = int.Parse(txtAirConditionerId.Text),
                AirConditionerName = txtAirConditionerName.Text,
                Warranty = txtWarranty.Text,
                SoundPressureLevel = txtSoundPressureLevel.Text,
                FeatureFunction = txtFeatureFunction.Text,
                Quantity = int.Parse(txtQuantity.Text),
                DollarPrice = double.Parse(txtDollarPrice.Text),
                SupplierId = cboSupplier.SelectedValue.ToString()
            };

            if (SelectedAirConditioner == null)
            {
                _airConditionerService.CreateAirConditioner(airConditioner);
            }
            else
            {
                _airConditionerService.UpdateAirConditioner(airConditioner);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

