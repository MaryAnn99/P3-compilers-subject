using System;
using System.Collections.Generic;
using System.Text;

namespace Compromiso1
{
    public class Validator
    {
        string input;
        public Validator(string input)
        {
            this.input = input;
        }
        public bool IsValidMatriculationNumber()
        {
            bool res = false;
            bool lookingSeparator = false;
            bool lookingLastNumbers = false;
            int cntLastNumbers = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '1' && !(lookingSeparator || lookingLastNumbers))
                {
                    i++;
                    if(input[i] == '9')
                    {
                        i++;
                        if(input[i] == '6')
                        {
                            i++;
                            if (input[i] >= '2' && input[i] <= '9')
                            {
                                lookingSeparator = true;
                                continue;
                            }
                            else
                            {
                                res = false;
                                break;
                            }
                        }
                        else if(input[i] >= '7' && input[i] <= '9')
                        {
                            i++;
                            if (input[i] >= '0' && input[i] <= '9')
                            {
                                lookingSeparator = true;
                                continue;
                            }
                            else
                            {
                                res = false;
                                break;
                            }
                        }
                        else
                        {
                            res = false;
                            break;
                        }
                    }
                    else
                    {
                        res = false;
                        break;
                    }
                }else if(input[i] == '2' && !(lookingSeparator || lookingLastNumbers))
                {
                    i++;
                    if (input[i] == '0')
                    {
                        i++;
                        if(input[i] == '0' || input[i] == '1')
                        {
                            i++;
                            if (input[i] >= '0' && input[i] <= '9')
                            {
                                lookingSeparator = true;
                                continue;
                            }
                            else
                            {
                                res = false;
                                break;
                            }
                        }
                        else
                        {
                            res = false;
                            break;
                        }
                    }
                    else
                    {
                        res = false;
                        break;
                    }
                }
                else
                {
                    if (lookingSeparator)
                    {
                        if (input[i] == '-')
                        {
                            lookingSeparator = false;
                            lookingLastNumbers = true;
                            continue;
                        }
                        else
                        {
                            res = false;
                            break;
                        }
                    }
                    if (lookingLastNumbers)
                    {
                        if (input[i] >= '0' && input[i] <= '9')
                        {
                            cntLastNumbers++;
                            if(cntLastNumbers == 4)
                            {
                                res = true;
                                lookingLastNumbers = false;
                            }
                            continue;
                        }
                        else
                        {
                            res = false;
                            break;
                        }
                    }
                    res = false;
                    break;
                }
            }
            return res;
        }

        public bool IsValidPVASubjectCode()
        {
            bool res = false;
            HashSet<string> recinto = new HashSet<string> { "CDS", "CSTI" };
            HashSet<string> codigoAsignatura = new HashSet<string> { "ADH", "ADM", "ARQ", "ART", "BIO", "CDP", 
                "CEDILE", "CHU", "CIED-HUMANO", "CITA", "CN", "CNT", "COM", "DEP", "DER", "DIG", "DIN", "EC", 
                "EDN", "EDS", "EDU", "EEM", "EEN", "EGA", "EGC", "EGF", "EM", "EMM", "EOR", "ESA", "EST", "ET", 
                "FCS", "FIL", "FIS", "FORMACIÓN", "FOT", "FR", "HG", "IC", "ICC", "ICV", "IEL", "IEM", "II", 
                "IIS", "ILE", "IMC", "IME", "INFOTEP", "ING", "IPS", "ISC", "ITE", "ITT", "LAC", "LAE", "LAL", 
                "LEN", "LET", "LIN", "LLI", "MAC", "MAF", "MAG", "MAT", "MBI", "MCB", "MCC", "MCD", "MCE", "MCG", 
                "MCN", "MCS", "MCT", "MDA", "MDI", "MDN", "MDT", "MEC", "MED", "MEE", "MEF", "MEM", "MER", "MES", 
                "MG", "MGA", "MGB", "MGD", "MGE", "MGL", "MGM", "MGN", "MGO", "MGR", "MGX", "MHA", "MHC", "MIB", 
                "MIC", "MIE", "MIL", "MINERD", "MIS", "MLD", "MLE", "MNP", "MPC", "MPIO", "MPO", "MPR", "MPY", 
                "MRH", "MRU", "MSD", "MSG", "MTM", "MTR", "MXT", "NUT", "ORI", "PEG", "PEM", "PSI", "PUG", "PVA", 
                "PYM", "QMA", "QMC", "TDG", "TEP", "THU", "TMA", "TPW", "TSA", "TSE", "TSS", "TTF", "UTAI" };

            bool lookingRecinto = true;
            /*
            for(int i = 0; i < input.Length; i++)
            {
                if(lookingRecinto )
            } */
            return res;
        }

        public bool IsValidDominicanPhoneNumber()
        {
            bool res = false;


            return res;
        }

        public bool IsValidEmailAddress()
        {
            bool res = false;


            return res;
        }
        public bool IsValidURLAddress()
        {
            bool res = false;


            return res;
        }
    }
}
