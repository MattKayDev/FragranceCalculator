using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FragranceCalculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FragranceCalculator.ViewModels
{
    public partial class CalculatorPageViewModel : BaseViewModel
    {
        private readonly int _maxPercentage;
        private readonly string vesselFillLabel;
        private readonly string numberOfVesselsLabel;

        private int _totalPercentage;
        private int vesselFill;
        private int numberOfVessels;
        private double totalFragrance;
        private double totalWaxWeight;
        private double fragrancePerVessel;
        private double waxPerVessel;
        public CalculatorPageViewModel() 
        {
            _maxPercentage = 12;
            vesselFillLabel = "Vessel fill";
            numberOfVesselsLabel = "Number of vessels";

            VesselFill = 0;
        }

        public string VesselFillLabel { get => this.vesselFillLabel; }

        public string NumberOfVesselsLabel { get => this.numberOfVesselsLabel; }
        public int MaxPercentage { get => _maxPercentage; }

        public int TotalPercentage
        {
            get => _totalPercentage;

            set
            {
                if (_totalPercentage != value)
                {
                    _totalPercentage = value;
                    OnPropertyChanged();
                }
            }
        }


        public int VesselFill
        {
            get => this.vesselFill;

            set
            {
                if (this.vesselFill != value)
                {
                    this.vesselFill = value;
                    OnPropertyChanged();
                }
            }
        }

        public int NumberOfVessels
        {
            get => this.numberOfVessels;

            set
            {
                if (this.numberOfVessels != value)
                {
                    this.numberOfVessels = value;
                    OnPropertyChanged();
                }
            }
        }

        public double TotalWaxWeight
        {
            get => this.totalWaxWeight;

            set
            {
                if (this.totalWaxWeight != value)
                {
                    this.totalWaxWeight = value;
                    OnPropertyChanged();
                }
            }
        }


        public double TotalFragrance
        {
            get => this.totalFragrance;

            set
            {
                if (this.totalFragrance != value)
                {
                    this.totalFragrance = value;
                    OnPropertyChanged();
                }
            }
        }

        public double FragrancePerVessel
        {
            get => this.fragrancePerVessel;

            set
            {
                if (this.fragrancePerVessel != value)
                {
                    this.fragrancePerVessel = value;
                    OnPropertyChanged();
                }
            }
        }

        public double WaxPerVessel
        {
            get => this.waxPerVessel; 
            
            set
            {
                if (this.waxPerVessel != value)
                {
                    this.waxPerVessel = value;
                    OnPropertyChanged();
                }
            }
        }

        [RelayCommand]
        private void VesselFillChangedPlus()
        {
                this.VesselFill += 1;
        }

        [RelayCommand]
        private void VesselFillChangedMinus()
        {
            if (this.VesselFill > 0)
            {
                this.VesselFill -= 1;
            }
        }

        [RelayCommand]
        private void NumberOfVesselsPlus()
        {
            this.NumberOfVessels += 1;
        }

        [RelayCommand]
        private void NumberOfVesselsMinus()
        {
            if (this.NumberOfVessels > 0)
            {
                this.NumberOfVessels -= 1;
            }
        }

        [RelayCommand]
        private void Calculate()
        {
            this.FragrancePerVessel = Calculator.FragrancePerVessel(this.VesselFill, this.TotalPercentage);
            this.WaxPerVessel = Calculator.WaxPerVessel(this.VesselFill, this.TotalPercentage);
            this.TotalFragrance = Calculator.TotalFragranceWeight(this.FragrancePerVessel, this.NumberOfVessels);
            this.TotalWaxWeight = Calculator.TotalWaxWeight(this.WaxPerVessel, this.NumberOfVessels);
        }
    }
}
