using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class ParticipantMaster
    {
        /// <summary>
        /// Gets or Sets participants id.
        /// </summary>
        public int Id
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets or Sets Participants Type.
        /// </summary>
        public string Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets or Sets Participants Name.
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets or Sets structure of participants.
        /// </summary>
        public Object Stucture
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets or Sets Inchi key of structure.
        /// </summary>
        public string InchiKey
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets or Sets structure unique number.
        /// </summary>
        public string StructureNum
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets or Sets Synonyms.
        /// </summary>
        public string Synonyms
        {
            get;
            set;
        }

    }
}
