using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------
using CloudDesktopApp.Helper;
using Newtonsoft.Json;


namespace CloudDesktopApp.ApiOperations
{
    // This method used for the 
    class ProfileApiService
    {
        public string commonUrl;
        public ProfileApiService()
        {
            this.commonUrl = "user/profile/";
        }

        // This method get the profile types 
        public List<ProfileTypes> getProfilesType()
        {
            List<ProfileTypes> result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "types", "GET", null, true);
            if (resultApi != null)
            {
                result = JsonConvert.DeserializeObject<List<ProfileTypes>>(resultApi.ToString());
            }
            return result;
        }

        public List<ProfileModel> getProfiles(Boolean recall)
        {
            List<ProfileModel> result = null;
            if (GlobalClass.profileModelList == null || recall)
            {
                Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "getAll", "GET", null, true);
                if (CommonClasses.checkResposeResult(resultApi))
                {
                    result = JsonConvert.DeserializeObject<List<ProfileModel>>(resultApi.ToString());
                    GlobalClass.profileModelList = result;
                    GlobalClass.profileTables = new ListToDataTableConvetor().ToDataTable<ProfileModel>(result);
                }
                else
                {
                    throw new Exception(CommonMessage.PROFILE_NOT_FOUND);
                }
            }
            else
            {
                result = GlobalClass.profileModelList;
            }
            
            return result;
        }

        // This method used for the creating profile
        public ProfileModel createProfile(string userBodyData)
        {
            ProfileModel result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "saveProfile", "POST", userBodyData, true);
            if (CommonClasses.checkResposeResult(resultApi))
            {
                result = JsonConvert.DeserializeObject<ProfileModel>(resultApi.ToString());
                this.getProfiles(true);
            }
            else
            {
                throw new Exception(CommonMessage.PROFILE_NOT_SAVE);
            }
            return result;
        }

        // This method used for the update the profile
        public ProfileModel updateProfile(ProfileModel userProfile, string userBodyData)
        {
            ProfileModel result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + userProfile.profileId + "/updateProfile", "PUT", userBodyData, true);
            if (CommonClasses.checkResposeResult(resultApi))
            {
                result = JsonConvert.DeserializeObject<ProfileModel>(resultApi.ToString());
                this.getProfiles(true);
            }
            else
            {
                throw new Exception(CommonMessage.PROFILE_UPDATE_UNSUCCESS);
            }
            return result;
        }

        // This method used for the update the profile
        public String deleteProfile(ProfileModel profileModel)
        {
            String result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + profileModel.profileId, "DELETE", null, true);
            if (CommonClasses.checkResposeResult(resultApi))
            {
                result = resultApi.ToString();
                this.getProfiles(true);
            }
            else
            {
                throw new Exception(CommonMessage.PROFILE_DELETE_UNSUCCESS_MESSAGE);
            }
            return result;
        }
    }
}
