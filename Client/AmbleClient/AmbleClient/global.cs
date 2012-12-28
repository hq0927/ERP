﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows;
using AmbleAppServer.AccountMgr;
using AmbleAppServer.customerVendorMgr;

namespace AmbleClient

{
    enum JobDescription
    { admin=0,boss,sales,saleManager,buyer,buyerManager,warehousekeeper,wareshousekeeperManager,financial,financialManager
    
    }

    public static class UserInfo
    {
        public static int UserId;
        public static string UserName;
    
    }



    public static class GlobalRemotingClient
    {

        private static AccountMgr mgr = null;
        private static CustomerVendorMgr cvMgr = null;


        public static AccountMgr GetAccountMgr()
        {
            if (mgr == null)
            {
                ChannelServices.RegisterChannel(new TcpClientChannel(), false);
                mgr = (AccountMgr)Activator.GetObject(typeof(AccountMgr),
               "tcp://192.168.1.104:1111/AccountMgr");
                return mgr;
            }
            else
            {
                return mgr;
            }

        }

        public static CustomerVendorMgr GetCustomerVendorMgr()
        {
            if (cvMgr == null)
            {
                cvMgr = (CustomerVendorMgr)Activator.GetObject(typeof(CustomerVendorMgr),
                  "tcp://192.168.1.104:1111/CustomerVendorMgr");
                return cvMgr;
            }
            else
            {
                return cvMgr;
            }


        }


    }
}