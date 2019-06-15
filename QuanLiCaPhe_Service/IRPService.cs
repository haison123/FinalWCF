using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL_QLCP;
using DTO_QLCP;
using System.Data;

namespace QuanLiCaPhe_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRPService" in both code and config file together.
    [ServiceContract]
    public interface IRPService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        DSBangLuong report_BL(int t);
        [OperationContract]
        DSBanSDNhieu report_BSDN(int i);
        [OperationContract]
        DSCTBanHang report_BH_ngay(DateTime ngay);
        [OperationContract]
        DSCTBanHang report_BH_mamon(string maMon);
        [OperationContract]
        DSCTBanHang report_BH(DateTime ngay, string maMon);
        [OperationContract]
        DSDoanhThu report_DT();
    }
}
