using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChemInform.Bll;
using System.Data;


namespace ChemInform.Common
{
    public static class ConvertToUserDefinedLists
    {
        #region SpectralInfo related Mehthods

        public static SpectralInfo ConvertToSpectralData(DataSet spectralData)
        {
            SpectralInfo spectralInfo = null;
            try
            {
                if (spectralData != null)
                {
                    if (spectralData.Tables.Count > 0)
                    {
                        List<SpectralInfo> lstSpectralInfo = new List<SpectralInfo>();

                        lstSpectralInfo = (from p in spectralData.Tables[0].AsEnumerable()
                                           select new SpectralInfo
                                           {
                                               ArticleInformation = GetArticleInfoFromTable(spectralData.Tables[1]),
                                               CompoundInformation = GetCompoundInfoFromTable(spectralData.Tables[2]),
                                               NMRSpectralList = GetNMRSpectralInfoFromTable(spectralData.Tables[0]),
                                               OtherSpectralList = GetOtherSpectralInfoFromTable(spectralData.Tables[3])

                                           }).ToList();

                        spectralInfo = lstSpectralInfo[0];
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return spectralInfo;
        }

        private static ArticleInfo GetArticleInfoFromTable(DataTable articleData)
        {
            ArticleInfo objArticleInfo = null;
            try
            {
                if (articleData != null)
                {
                    List<ArticleInfo> lstArticleInfo = new List<ArticleInfo>();
                    if (articleData.Rows.Count > 0)
                    {
                        lstArticleInfo = (from p in articleData.AsEnumerable()
                                          select new ArticleInfo
                                            {
                                                JournalName = p.Field<string>("ARTICLE_NAME"),
                                                Issue = p.Field<string>("ISSUE"),
                                                Volume = p.Field<string>("VOLUME"),
                                                DOI = p.Field<string>("DOI"),
                                                Authors = p.Field<string>("AUTHORS")
                                            }).ToList();

                        objArticleInfo = lstArticleInfo[0];
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return objArticleInfo;
        }

        private static CompoundInfo GetCompoundInfoFromTable(DataTable compoundData)
        {
            CompoundInfo objCompInfo = null;
            try
            {
                if (compoundData != null)
                {
                    List<CompoundInfo> lstCompoundInfo = new List<CompoundInfo>();
                    if (compoundData.Rows.Count > 0)
                    {
                        lstCompoundInfo = (from p in compoundData.AsEnumerable()
                                           select new CompoundInfo
                                           {
                                               Compound = p.Field<object>("COMPOUND_STRUCTURE"),
                                               CompoundNo = p.Field<string>("COMPOUND_NO"),
                                               IUPACName = p.Field<string>("IUPAC_NAME"),
                                               MolFormula = p.Field<string>("MOLECULE_FORMULA"),
                                               MolWeight = p.Field<string>("MOLECULE_WEIGHT"),
                                               PageNo = p.Field<string>("PAGE_NO"),
                                               Comments = p.Field<string>("COMMENTS"),
                                               Synonyms = p.Field<string>("SYSNONYMS")
                                           }).ToList();

                        objCompInfo = lstCompoundInfo[0];
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return objCompInfo;
        }

        private static List<NMRSpectralInfo> GetNMRSpectralInfoFromTable(DataTable nmrSpectralData)
        {
            List<NMRSpectralInfo> lstNMRSpectralInfo = null;
            try
            {
                if (nmrSpectralData != null)
                {
                    lstNMRSpectralInfo = new List<NMRSpectralInfo>();
                    if (nmrSpectralData.Rows.Count > 0)
                    {
                        lstNMRSpectralInfo = (from p in nmrSpectralData.AsEnumerable()
                                              select new NMRSpectralInfo
                                              {
                                                  SpectroMeter = p.Field<string>("SPECTROMETER"),
                                                  Solvent = p.Field<string>("SOLVENT_NAME"),
                                                  Frequency = p.Field<string>("FREQUENCY"),
                                                  Nucleus = p.Field<string>("NUCLEUS"),
                                                  StdSolvent = p.Field<string>("STANDARD_SOLVENT_NAME"),
                                                  ShiftValues = p.Field<string>("SHIFT_VALUES")
                                              }).ToList();

                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstNMRSpectralInfo;
        }

        private static List<OtherSpectralInfo> GetOtherSpectralInfoFromTable(DataTable otherSpectralData)
        {
            List<OtherSpectralInfo> lstOthSpectralInfo = null;
            try
            {
                if (otherSpectralData != null)
                {
                    lstOthSpectralInfo = new List<OtherSpectralInfo>();
                    if (otherSpectralData.Rows.Count > 0)
                    {
                        lstOthSpectralInfo = (from p in otherSpectralData.AsEnumerable()
                                              select new OtherSpectralInfo
                                              {
                                                  SpectroMeter = p.Field<string>("SPECTROMETER"),
                                                  ValueType = p.Field<string>("SPECTRA_TYPE"),
                                                  ElectronVolts = p.Field<string>("ELECTRON_VOLTS"),
                                                  Method = p.Field<string>("METHOD"),
                                                  SamplePreparation = p.Field<string>("SAMPLE_PREPARATION"),
                                                  PeakValues = p.Field<string>("PEAK_VALUES"),
                                                  Comments = p.Field<string>("COMMENTS")
                                              }).ToList();

                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstOthSpectralInfo;
        }

        #endregion

        #region ReactionInfo related mehtods
              
        private static List<ReactionRefInfo> GetReactionRefInfoFromTable(DataTable rxnRefData)
        {
            List<ReactionRefInfo> lstRxnRefInfo = null;
            try
            {
                if (rxnRefData != null)
                {
                    lstRxnRefInfo = new List<ReactionRefInfo>();
                    if (rxnRefData.Rows.Count > 0)
                    {
                        lstRxnRefInfo = (from p in rxnRefData.AsEnumerable()
                                         select new ReactionRefInfo
                                           {
                                               ExtRegNo = p.Field<int>("EXT_REG_NO"),
                                               RefPath = p.Field<string>("RR_PATH"),
                                               Step = p.Field<string>("STEP")
                                           }).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstRxnRefInfo;
        }
               
        private static List<ProductInfo> GetReactionProductsInfoFromTable(DataTable produtsData)
        {
            List<ProductInfo> lstProducts = null;
            try
            {
                if (produtsData != null)
                {
                    lstProducts = new List<ProductInfo>();
                    if (produtsData.Rows.Count > 0)
                    {
                        lstProducts = (from p in produtsData.AsEnumerable()
                                       select new ProductInfo
                                       {
                                           ProductID = p.Field<int>("CR_ID"),
                                           //CrossRefNo = p.Field<int>("EXT_REG_NO"),
                                           ProductName = p.Field<string>("PRODUCT_NAME"),
                                           Structure = p.Field<object>("PROD_STRUCTURE"),
                                           StructureNo = p.Field<string>("STRUCTURE_NO"),
                                           Yield = p.Field<string>("YIELD"),
                                           CS = p.Field<string>("CHEMO_SELECTIVITY"),
                                           DS = p.Field<string>("DIASTEREO_SELECTIVITY"),
                                           DE = p.Field<string>("DIASTEREOMERIC_EXCESS"),
                                           EE = p.Field<string>("ENANTIOMERIC_EXCESS"),
                                       }).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstProducts;
        }

        private static List<StepInfo> GetReactionStepsFromTable(DataTable rxnStepsData, DataTable rxnPartpnts, DataTable rxnConditions)
        {
            List<StepInfo> lstSteps = null;
            try
            {
                if (rxnStepsData != null)
                {
                    lstSteps = new List<StepInfo>();
                    if (rxnStepsData.Rows.Count > 0)
                    {
                        lstSteps = (from p in rxnStepsData.AsEnumerable()
                                    select new StepInfo
                                    {
                                        StepID = p.Field<int>("STEP_ID"),
                                        SerialNo = p.Field<int>("RXN_STEP_SNO"),
                                        StepYield = p.Field<string>("YIELD"),
                                        StepParticipants = GetStepParticipantsInfoOnStepIDFromTable(p.Field<int>("STEP_ID"), rxnPartpnts),
                                        StepConditions = GetStepConditionsInfoOnStepIDFromTable(p.Field<int>("STEP_ID"), rxnConditions)
                                    }).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstSteps;
        }

        private static List<ParticipantInfo> GetStepParticipantsInfoOnStepIDFromTable(int stepID, DataTable participantsData)
        {
            List<ParticipantInfo> lstParticipants = null;
            try
            {
                if (participantsData != null)
                {
                    lstParticipants = new List<ParticipantInfo>();
                    if (participantsData.Rows.Count > 0)
                    {
                        lstParticipants = (from p in participantsData.AsEnumerable()
                                           where p.Field<int>("STEP_ID") == stepID
                                           select new ParticipantInfo
                                           {
                                               ParticipantID = p.Field<int>("PRPNT_ID"),
                                               ParticipantType = p.Field<string>("PRPNT_TYPE"),
                                               RxnStepID = p.Field<int>("RXN_STEP_ID"),
                                               Structure = p.Field<object>("PRPNT_STRUCTURE"),
                                               ParticipantName = p.Field<string>("PRPNT_NAME"),
                                               StructureNo = p.Field<string>("STRUCTURE_NO"),
                                               Grade = p.Field<string>("GRADE")
                                           }).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstParticipants;
        }

        private static List<ConditionInfo> GetStepConditionsInfoOnStepIDFromTable(int stepID, DataTable conditionssData)
        {
            List<ConditionInfo> lstStepConds = null;
            try
            {
                if (conditionssData != null)
                {
                    lstStepConds = new List<ConditionInfo>();
                    if (conditionssData.Rows.Count > 0)
                    {
                        lstStepConds = (from p in conditionssData.AsEnumerable()
                                        where p.Field<int>("STEP_ID") == stepID
                                        select new ConditionInfo
                                        {
                                            ConditionID = p.Field<int>("CONDITION_ID"),
                                            RxnStepID = p.Field<int>("RXN_STEP_ID"),
                                            Time = p.Field<string>("COND_TIME"),
                                            Temperature = p.Field<string>("TEMPERATURE"),
                                            Pressure = p.Field<string>("PRESSURE"),
                                            PH = p.Field<string>("PH"),
                                            WarmUp = p.Field<bool>("IS_WARMUP"),
                                            CoolDown = p.Field<bool>("IS_COOL_DOWN"),
                                            Reflux = p.Field<bool>("IS_REFLUX"),
                                            Other = p.Field<string>("OTHER_CONDITIONS"),
                                            Operation = p.Field<string>("OPERATION")
                                        }).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstStepConds;
        }

        #endregion
    }
}
