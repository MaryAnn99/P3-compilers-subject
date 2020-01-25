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
            bool lookingForFirstNumero = false;
            bool lookingForSecondNumero = false;
            bool lookingForCodigoAsignatura = false;
            bool lookingForThreeLastDigits = false;
            int cntNumero = 0;
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == '-')  
                {
                    if (lookingRecinto)
                    {
                        lookingRecinto = false;
                        if (!recinto.Contains(stringBuilder.ToString()))
                        {
                            res = false;
                            break;
                        }
                        lookingForFirstNumero = true;
                    }
                    if (lookingForFirstNumero)
                    {
                        lookingForFirstNumero = false;
                        cntNumero = 0;
                        lookingForSecondNumero = true;
                    }
                    if (lookingForSecondNumero)
                    {
                        lookingForSecondNumero = false;
                        cntNumero = 0;
                        lookingForCodigoAsignatura = true;
                        stringBuilder = new StringBuilder();
                    }
                    if (lookingForCodigoAsignatura)
                    {
                        lookingForCodigoAsignatura = false;
                        if (!codigoAsignatura.Contains(stringBuilder.ToString()))
                        {
                            res = false;
                            break;
                        }
                        lookingForThreeLastDigits = true;
                    }
                    continue;
                }else if (lookingRecinto)
                {
                    stringBuilder.Append(input[i]);
                }else if (lookingForFirstNumero || lookingForSecondNumero)
                {
                    if(input[i] >= '0' && input[i] <= '9' && cntNumero < 4)
                    {
                        cntNumero++;
                        continue;
                    }
                    else
                    {
                        res = false;
                        break;
                    }
                }else if (lookingForCodigoAsignatura)
                {
                    stringBuilder.Append(input[i]);
                }else if (lookingForThreeLastDigits)
                {
                    if (input[i] >= '0' && input[i] <= '9' && cntNumero < 3)
                    {
                        cntNumero++;
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
            return res;
        }

        public bool IsValidDominicanPhoneNumber()
        {
            bool res = false;

            bool lookingForCodigoArea = true;
            bool lookingForNumeroV2 = false;
            bool lookingForSeparator = false;
            bool lookingForNumero = false;
            int cntNumero = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (lookingForCodigoArea)
                {
                    if (input[i] == '8')
                    {
                        i++;
                        if (input[i] == '0' || input[i] == '2' || input[i] == '4')
                        {
                            i++;
                            if (input[i] == '9')
                            {
                                lookingForCodigoArea = false;
                                lookingForSeparator = true;
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
                }else if (lookingForSeparator)
                {
                    if(input[i] == '-')
                    {
                        if (lookingForNumeroV2)
                        {
                            lookingForNumeroV2 = false;
                            lookingForNumero = true;
                        }
                        else
                        {
                            lookingForNumeroV2 = true;
                        }
                        cntNumero = 0;
                        continue;
                    }
                    else
                    {
                        res = false;
                        break;
                    }
                }else if (lookingForNumeroV2)
                {
                    if (input[i] >= '0' && input[i] <= '9' && cntNumero < 3)
                    {
                        cntNumero++;
                        if(cntNumero == 3)
                        {
                            lookingForSeparator = true;
                        }
                        continue;
                    }
                    else
                    {
                        res = false;
                        break;
                    }
                }else if (lookingForNumero)
                {
                    if (input[i] >= '0' && input[i] <= '9' && cntNumero < 4)
                    {
                        cntNumero++;
                        if (cntNumero == 4)
                        {
                            lookingForNumero = false;
                            res = true;
                        }
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

            return res;
        }

        public bool IsValidEmailAddress()
        {
            bool res = false;
            bool lookingForLocalPart = true;
            bool lookingForDomainPart = false;
            bool firstCharDomainPart = false;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '@')
                {
                    if (lookingForLocalPart)
                    {
                        lookingForLocalPart = false;
                        lookingForDomainPart = true;
                        firstCharDomainPart = true;
                    }
                    else
                    {
                        res = false;
                        break;
                    }
                }else if (lookingForLocalPart)
                {
                    if(!( (input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z') || 
                        (input[i] >= '0' && input[i] <= '9')))
                    {
                        res = false;
                        break;
                    }
                }else if (lookingForDomainPart)
                {
                    if (firstCharDomainPart)
                    {
                        if ((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z'))
                        {
                            firstCharDomainPart = false;
                            res = true;
                            continue;
                        }
                        else
                        {
                            res = false;
                            break;
                        }
                    }
                    if (!((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z') ||
                        (input[i] >= '0' && input[i] <= '9')))
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
            return res;
        }
        public bool IsValidURLAddress()
        {
            /* If an authority component is present, then the path component must either be empty 
             * or begin with a slash(/).If an authority component is absent, then the path cannot 
             * begin with an empty segment, that is with two slashes(//), as the following characters 
             * would be interpreted as an authority component.
            */
           bool res = false;
            
            bool lookingForScheme = true;
            bool firstCharScheme = true;
            bool lookingForPathOrAuthorityComponent = false;
            bool lookingForAuthorityComponent = true;
            bool lookingForPath = true;
            bool lookingForQuery = true;
            bool lookingForFragment = true;
            int cntSlash = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (lookingForScheme)
                {
                    if(input[i] == ':')
                    {
                        lookingForScheme = false;
                        lookingForPathOrAuthorityComponent = true;
                        continue;
                    }
                    if (firstCharScheme)
                    {
                        if ((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z'))
                        {
                            firstCharScheme = false;
                            continue;
                        }
                        else
                        {
                            res = false;
                            break;
                        }
                    }
                    if (!((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z') ||
                        (input[i] >= '0' && input[i] <= '9')))
                    {
                        res = false;
                        break;
                    }
                }else if(lookingForPathOrAuthorityComponent)
                {
                    if(input[i] == '/')
                    {
                        cntSlash++;
                    }
                    else
                    {
                        // The rule mentioned at the beginning let us assume that 2 slashes
                        // can be interpreted as an authority component.
                        if (cntSlash == 2) 
                        {
                            lookingForAuthorityComponent = true;
                            i --;
                        }
                        else if(cntSlash == 1)
                        {
                            lookingForPath = true;
                            i--;
                        }
                        else
                        {
                            res = false;
                            break;
                        }
                        lookingForPathOrAuthorityComponent = false;
                    }
                }else if (lookingForAuthorityComponent)
                {
                    if(input[i] == '/')
                    {
                        lookingForAuthorityComponent = false;
                        lookingForPath = true;
                        continue;
                    }
                }else if (lookingForPath)
                {
                    if(input[i] == '?')
                    {
                        lookingForPath = false;
                        lookingForQuery = true;
                        continue;
                    }
                    else if(input[i] == '#')
                    {
                        lookingForPath = false;
                        lookingForFragment = true;
                        continue;
                    }
                    else if (!((input[i] >= 'a' && input[i] <= 'z') || 
                        (input[i] >= 'A' && input[i] <= 'Z') ||
                        (input[i] >= '0' && input[i] <= '9') || input[i] == '/'))
                    {
                        res = false;
                        break;
                    }
                }else if (lookingForQuery)
                {

                }else if (lookingForFragment)
                {
                    res = true;
                    if (!((input[i] >= 'a' && input[i] <= 'z') ||
                        (input[i] >= 'A' && input[i] <= 'Z') ||
                        (input[i] >= '0' && input[i] <= '9')))
                    {
                        res = false;
                        break;
                    }
                }
            }
            return res;
        }
    }
}
