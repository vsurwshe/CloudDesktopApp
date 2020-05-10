using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------
using CloudDesktopApp.Helper;
using Newtonsoft.Json;

namespace CloudDesktopApp.ApiOperations
{
    class HotelTableServicesApi
    {
        public string commonUrl;
        public HotelTableServicesApi()
        {
            String profileId = Properties.Settings.Default.profileId;
            if (profileId != null)
            {
                this.commonUrl = "user/profile/" + profileId + "/hotelTable/";
            }
            else
            {
                UserMessage.showWarningMessage(CommonMessage.PROFILE_CREATED_MESSAGE);
            }
        }

        // This method used for the get the hotel tabel list 
        public List<HotelTableModel> getHotelTables(Boolean recall)
        {
            List<HotelTableModel> result = null;
            if (GlobalClass.hotelTableModelList == null || recall)
            {
                Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "gets", "GET", null, true);
                if (CommonClasses.checkResposeResult(resultApi))
                {
                    result = JsonConvert.DeserializeObject<List<HotelTableModel>>(resultApi.ToString());
                    GlobalClass.hotelTableModelList = result;
                }
                else
                {
                    throw new Exception(CommonMessage.HOTEL_TABLE_NO_RECORD_MESSAGE);
                }
            }
            else
            {
                result = GlobalClass.hotelTableModelList;
            }
            return result;
        }

        // This method used for the saving hotel tabel details
        public HotelTableModel saveHotelTable(string hotelTableBodyData)
        {
            HotelTableModel result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "save", "POST", hotelTableBodyData, true);
            if (CommonClasses.checkResposeResult(resultApi))
            {
                result = JsonConvert.DeserializeObject<HotelTableModel>(resultApi.ToString());
                this.getHotelTables(true);
            }
            else
            {
                throw new Exception(CommonMessage.HOTEL_TABLE_SAVED_UNSUCCESS_MESSAGE);
            }
            return result;
        }

        // This method used for the update the hotel table deatils
        public HotelTableModel updateHotelTable(int hotelTableId, string hotelTableBodyData)
        {
            HotelTableModel result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "update/" + hotelTableId, "PUT", hotelTableBodyData, true);
            if (CommonClasses.checkResposeResult(resultApi))
            {
                result = JsonConvert.DeserializeObject<HotelTableModel>(resultApi.ToString());
                this.getHotelTables(true);
            }
            else
            {
                throw new Exception(CommonMessage.HOTEL_TABLE_UPDATE_UNSUCCESS_MESSAGE);
            }
            return result;
        }

        // This method used for the delete the hotel tabel deatils
        public String deleteHotelTable(HotelTableModel hotelTableModel)
        {
            String result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "delete/" + hotelTableModel.hotelTableId, "DELETE", null, true);
            if (CommonClasses.checkResposeResult(resultApi))
            {
                result = resultApi.ToString();
                this.getHotelTables(true);
            }
            else
            {
                throw new Exception(CommonMessage.HOTEL_TABLE_DELETE_UNSUCCESS_MESSAGE);
            }
            return result;
        }
    }
}
