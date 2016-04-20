using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices;

namespace ChemInform
{
    public class LdapAuthentication
    {
        public LdapAuthentication()
        {

        }//
        // TODO: Add constructor logic here
        //
        private string _path;
        private string _filterAttribute;

        public LdapAuthentication(string path)
        {
            _path = path;
        }

        /// <summary>
        /// Method TODO LDAP authentication with domain
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool IsAuthenticated(string domain, string username, string pwd)
        {
            string domainAndUsername = domain + @"\" + username;
            DirectoryEntry entry = new DirectoryEntry(_path, domainAndUsername, pwd);

            try
            {
                //return true; //for testing

                // Bind to the native AdsObject to force authentication.
                Object obj = entry.NativeObject;
                DirectorySearcher search = new DirectorySearcher(entry);
                search.Filter = "(SAMAccountName=" + username + ")";
                search.PropertiesToLoad.Add("cn");
                SearchResult result = search.FindOne();
                if (null == result)
                {
                    return false;
                }
                // Update the new path to the user in the directory
                _path = result.Path;
                _filterAttribute = (String)result.Properties["cn"][0];

            }
            catch (Exception ex)
            {
                return false;
                //throw new Exception("Error authenticating user. " + ex.Message);
            }
            return true;
        }

        public static bool ValidateUserWithLDAP(string username)
        {
            bool flag = false;
            try
            {
                if(!string.IsNullOrEmpty(username))
                {
                    DirectoryEntry entry = new DirectoryEntry("LDAP://gvkbio.com:389/DC=gvkbio,DC=com", "infh-admin1", "SaiBaba@786");

                    DirectorySearcher search = new DirectorySearcher(entry);

                    search.Filter = string.Format("SAMAccountName={0}", username);
                    SearchResult sResult = search.FindOne();

                    if (sResult != null)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag;
        }


        //public bool IsAuthenticatedByGroup(string userName, string userGroupName)
        //{
        //    bool status = false;
        //    try
        //    {
        //        //return true;
        //        string domainAdminUser = ConfigurationManager.AppSettings["DomainAdminUser"];
        //        string domainAdminPwd = ConfigurationManager.AppSettings["DomainAdminPwd"];
        //        string domainName = "gvkbio.com";  //Hardcoded here

        //        PrincipalContext ctxSys = new PrincipalContext(ContextType.Domain, domainName, domainAdminUser, domainAdminPwd);
        //        GroupPrincipal grp = GroupPrincipal.FindByIdentity(ctxSys, IdentityType.SamAccountName, userGroupName);
        //        if (grp != null)
        //        {
        //            DirectoryEntry de = (DirectoryEntry)grp.GetUnderlyingObject();
        //            object m = de.Invoke("Members");

        //            if (grp.Members.Contains(ctxSys, IdentityType.SamAccountName, userName))
        //            {
        //                status = true;
        //            }
        //            else
        //            {
        //                status = false;
        //            }
        //            grp.Dispose();
        //            ctxSys.Dispose();
        //        }
        //        else
        //        {
        //            status = false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    //status = true; //SKIP VALIDATION - FOR TESTING, UNCOMMENT WHEN LIVE
        //    return status;
        //}

        /// <summary>
        /// Method to get domain groups
        /// </summary>
        /// <returns></returns>
        //public string GetGroups()
        //{
        //    DirectorySearcher search = new DirectorySearcher(_path);
        //    search.Filter = "(cn=" + _filterAttribute + ")";
        //    search.PropertiesToLoad.Add("memberOf");
        //    StringBuilder groupNames = new StringBuilder();
        //    try
        //    {
        //        SearchResult result = search.FindOne();
        //        int propertyCount = result.Properties["memberOf"].Count;
        //        String dn;
        //        int equalsIndex, commaIndex;

        //        for (int propertyCounter = 0; propertyCounter < propertyCount;
        //             propertyCounter++)
        //        {
        //            dn = (String)result.Properties["memberOf"][propertyCounter];

        //            equalsIndex = dn.IndexOf("=", 1);
        //            commaIndex = dn.IndexOf(",", 1);
        //            if (-1 == equalsIndex)
        //            {
        //                return null;
        //            }
        //            groupNames.Append(dn.Substring((equalsIndex + 1),
        //                              (commaIndex - equalsIndex) - 1));
        //            groupNames.Append("|");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error obtaining group names. " +
        //          ex.Message);
        //    }
        //    return groupNames.ToString();
        //}
    }
}
