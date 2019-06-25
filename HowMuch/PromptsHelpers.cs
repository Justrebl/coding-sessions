using System;
using System.Linq;

namespace HMI
{
    public class PromptsHelpers
    {
        private readonly string[] CORRECT_YES = new string[] {"Oui", "oui", "Vrai","vrai"};
        private readonly string[] CORRECT_NO = new string[] {"Non", "non", "Faux", "faux"}; 

        public enum AnswerTypes
        {
            Caractere,
            NombrePositif,
            OuiNon
        }

#region Checkers
        public bool IsCorrectAnswerType(string inAnswer, AnswerTypes answerType)
        {
            bool isCorrectType = true;
            switch(answerType)
            {
                case AnswerTypes.Caractere :
                    char charResult = ' ';
                    isCorrectType = Char.TryParse(inAnswer, out charResult);
                    break;
                case AnswerTypes.NombrePositif : 
                    int intResult = 0;
                    isCorrectType = Int32.TryParse(inAnswer, out intResult) && intResult > 0;
                    break;
                case AnswerTypes.OuiNon : 
                    isCorrectType = isCorrectBoolean(inAnswer);
                    break;
            }
            return isCorrectType;
        }

        private bool isCorrectBoolean(string inBool)
        {
            if(CORRECT_YES.Contains(inBool) || CORRECT_NO.Contains(inBool))
            {
               return true; 
            }
            
            else
            {
                return false;
            }
            
        }
        #endregion
        
        #region Converters
            public int GetPositiveNumberFromString(string inString)
            {
                int result = 0;
                if(IsCorrectAnswerType(inString, AnswerTypes.NombrePositif))
                {
                    result = Int32.Parse(inString);
                    return result;
                }                    
                else 
                {
                    throw new Exception ("Le nombre que vous avez entré n'est pas valide !\n"+
                    "Merci d'en entrer un nouveau.");
                }
            }

            public bool GetBooleanFromYesNoString(string inBool)
            {
                bool result = true;
                if(isCorrectBoolean(inBool))
                {
                    if (CORRECT_YES.Contains(inBool))
                        result = true;
                    else if (CORRECT_NO.Contains(inBool))
                        result = false;

                    return result;
                }
                else
                {
                    throw new Exception ("La valeur entrée ne peut être considérée comme étant un Oui ou un Non\n"+
                    "Merci d'entrer une valeur compatible.");
                }
            }
        #endregion
    }
}
