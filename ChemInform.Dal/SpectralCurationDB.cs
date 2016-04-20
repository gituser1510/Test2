using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data;
using ChemInform.Bll;


namespace ChemInform.Dal
{
    public class SpectralCurationDB
    {
        public static bool UpdateArticleInformation(ArticleInfo articleInfo, UserInfo usrInfo)
        {
            bool blStatus = false;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "SAVE_ARTICLE_DATA";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_ARTICLE_ID", OracleDbType.Int32).Value = articleInfo.ArticleID;
                        oraCmd.Parameters.Add("PIC_JOURNAL_NAME", OracleDbType.Varchar2).Value = articleInfo.JournalName;
                        oraCmd.Parameters.Add("PIC_ISSUE", OracleDbType.NVarchar2).Value = articleInfo.Issue;
                        oraCmd.Parameters.Add("PIC_DOI", OracleDbType.NVarchar2).Value = articleInfo.DOI;
                        oraCmd.Parameters.Add("PIC_VOLUME", OracleDbType.Varchar2).Value = articleInfo.Volume;
                        oraCmd.Parameters.Add("PIC_AUTHORS", OracleDbType.Varchar2).Value = articleInfo.Authors;                
                                                
                        oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = usrInfo.UserID;

                        oraCon.Open();
                        oraCmd.ExecuteNonQuery();
                        oraCon.Close();

                        blStatus = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blStatus;
        }

        public static bool UpdateCompoundInformation(CompoundInfo compInfo, UserInfo usrInfo)
        {
            bool blStatus = false;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "SAVE_COMPOUND_DATA";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_COMP_ID", OracleDbType.Int32).Value = compInfo.CompoundID;
                        oraCmd.Parameters.Add("PIC_COMP_NO", OracleDbType.Varchar2).Value = compInfo.CompoundNo;
                        oraCmd.Parameters.Add("PIC_COMPOUND", OracleDbType.NVarchar2).Value = compInfo.Compound;
                        oraCmd.Parameters.Add("PIC_IUPAC", OracleDbType.NVarchar2).Value = compInfo.IUPACName;
                        oraCmd.Parameters.Add("PIC_INCHI_KEY", OracleDbType.Varchar2).Value = compInfo.InchiKey;
                        oraCmd.Parameters.Add("PIC_MOL_FORMULA", OracleDbType.Varchar2).Value = compInfo.MolFormula;
                        oraCmd.Parameters.Add("PIC_MOL_WEIGHT", OracleDbType.Varchar2).Value = compInfo.MolWeight;
                        oraCmd.Parameters.Add("PIC_PAGE_NO", OracleDbType.Varchar2).Value = compInfo.PageNo;
                        oraCmd.Parameters.Add("PIC_SYNONYMS", OracleDbType.Varchar2).Value = compInfo.Synonyms;
                        oraCmd.Parameters.Add("PIC_COMMENTS", OracleDbType.Varchar2).Value = compInfo.Comments;
                        
                        oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = usrInfo.UserID;

                        oraCon.Open();
                        oraCmd.ExecuteNonQuery();
                        oraCon.Close();

                        blStatus = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blStatus;
        }

        public static bool UpdateNMRSpectralInformation(NMRSpectralInfo nmrSpectralInfo, UserInfo usrInfo)
        {
            bool blStatus = false;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "SAVE_NMR_SPECTRAL_DATA";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_COMP_ID", OracleDbType.Int32).Value = nmrSpectralInfo.CompoundID;                        

                        //OracleParameter paNMRID = new OracleParameter();
                        //paNMRID.ParameterName = "PINA_NMRID";
                        //paNMRID.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                        //paNMRID.OracleDbType = OracleDbType.Int32;
                        //if (compInfo..TKIDs != null)
                        //{
                        //    if (compInfo.TKIDs.Count > 0)
                        //    {
                        //        paNMRID.Value = compInfo.TKIDs.ToArray();
                        //    }
                        //    else
                        //    {
                        //        paNMRID.Value = new string[1] { null };
                        //        paNMRID.Size = 0;
                        //    }
                        //}
                        //else
                        //{
                        //    paNMRID.Value = new string[1] { null };
                        //    paNMRID.Size = 0;
                        //}
                        //oraCmd.Parameters.Add(paNMRID);

                        oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = usrInfo.UserID;

                        oraCon.Open();
                        oraCmd.ExecuteNonQuery();
                        oraCon.Close();

                        blStatus = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blStatus;
        }

        public static bool UpdateOtherSpectralInformation(OtherSpectralInfo othSpectralInfo, UserInfo usrInfo)
        {
            bool blStatus = false;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "SAVE_OTHER_SPECTRAL_DATA";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_COMP_ID", OracleDbType.Int32).Value = othSpectralInfo.CompoundID;

                        //OracleParameter paNMRID = new OracleParameter();
                        //paNMRID.ParameterName = "PINA_NMRID";
                        //paNMRID.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                        //paNMRID.OracleDbType = OracleDbType.Int32;
                        //if (compInfo..TKIDs != null)
                        //{
                        //    if (compInfo.TKIDs.Count > 0)
                        //    {
                        //        paNMRID.Value = compInfo.TKIDs.ToArray();
                        //    }
                        //    else
                        //    {
                        //        paNMRID.Value = new string[1] { null };
                        //        paNMRID.Size = 0;
                        //    }
                        //}
                        //else
                        //{
                        //    paNMRID.Value = new string[1] { null };
                        //    paNMRID.Size = 0;
                        //}
                        //oraCmd.Parameters.Add(paNMRID);

                        oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = usrInfo.UserID;

                        oraCon.Open();
                        oraCmd.ExecuteNonQuery();
                        oraCon.Close();

                        blStatus = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blStatus;
        }

        public static int GetNewCompoundIDOnDocumentID(int docID)
        {
            int intCompID = 0;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCon.Open();
                        oraCmd.CommandText = "GET_NEW_COMPOUNDID_ON_DOC_ID";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_DOC_ID", OracleDbType.Int32).Value = docID;

                        object objRetVal = oraCmd.ExecuteScalar();
                        oraCon.Close();

                        if (objRetVal != null)
                        {
                            intCompID = Convert.ToInt32(objRetVal);
                        }                       
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intCompID;
        }

        public static DataTable GetCompoundsOnDocumentID(int docID)
        {
            DataTable dtCompounds = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "GET_COMPOUNDS_ON_DOC_ID";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_DOC_ID", OracleDbType.Int32).Value = docID;
                        oraCmd.Parameters.Add("PORC_COMP", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        dtCompounds = new DataTable();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dtCompounds);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCompounds;
        }

        public static DataSet GetCompoundDataOnID(CompoundInfo compInfo)
        {
            DataSet dsCompData = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "GET_COMPOUND_DATA";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_COMP_ID", OracleDbType.Int32).Value = compInfo.CompoundID;
                        oraCmd.Parameters.Add("PORC_COMP", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        dsCompData = new DataSet();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dsCompData);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dsCompData;
        }

        public static bool DeleteCompoundDataOnID(CompoundInfo compInfo)
        {
            bool blStatus = false;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCon.Open();
                        oraCmd.CommandText = "DELETE_COMPOUND_DATA";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_COMP_ID", OracleDbType.Int32).Value = compInfo.CompoundID;

                        oraCmd.ExecuteNonQuery();
                        oraCon.Close();
                        blStatus = true;
                    }
                }        
            }
            catch (Exception ex)
            {               
                throw ex;
            }
            return blStatus;
        }
    }
}
