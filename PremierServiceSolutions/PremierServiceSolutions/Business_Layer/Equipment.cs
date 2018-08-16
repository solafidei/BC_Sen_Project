using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremierServiceSolutions.Data_Layer;

namespace PremierServiceSolutions.Business_Layer
{
    class Equipment
    {
        private string equipmentType;
        private string equipmentName;
        private string equipmentModel;
        Data_Layer.DataHandler data = new Data_Layer.DataHandler();

        public string EquipmentType
        {
            get
            {
                return equipmentType;
            }

            set
            {
                equipmentType = value;
            }
        }

        public string EquipmentName
        {
            get
            {
                return equipmentName;
            }

            set
            {
                equipmentName = value;
            }
        }

        public string EquipmentModel
        {
            get
            {
                return equipmentModel;
            }

            set
            {
                equipmentModel = value;
            }
        }

        public Equipment(string equipmentType, string equipmentName, string equipmentModel)
        {
            this.equipmentType = equipmentType;
            this.equipmentName = equipmentName;
            this.equipmentModel = equipmentModel;

        }

        public List<Equipment> ViewEquipmentWithType()
        {
            List<Equipment> equip = data.ViewEquipmentWithType();
            return equip;
        }
        public Equipment()
        {

        }
    }
}
