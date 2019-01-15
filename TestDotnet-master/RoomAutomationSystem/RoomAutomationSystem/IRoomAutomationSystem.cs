using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RoomAutomationSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRoomAutomationSystem" in both code and config file together.
    [ServiceContract]
    public interface IRoomAutomationSystem
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Xml,
        RequestFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "Temperature")]
        Temperature GetTemperatureFrequency();
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Xml,
        RequestFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "Pressure")]
        Pressure GetPressureFrequency();
        [OperationContract] 
        [WebGet(ResponseFormat = WebMessageFormat.Xml,
        RequestFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "Humidity")]
        Humidity GetHumidityFrequency();
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Xml,
        RequestFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "lux")]
        Lux GetLuxFrequency();
    }
}
