using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UV_DLP_3D_Printer.Util.Sequence
{
    /// <summary>
    /// base class for a generic command sequence
    /// </summary>
    public class CommandSequence
    {

        public const int COMMAND_TYPE_SCRIPT = 0; // script sequence
        public const int COMMAND_TYPE_GCODE = 1; // gcode sequence
        public const int COMMAND_TYPE_SPAWN_PROCESS = 2; // spawn a new process 
        public string m_name; // the name of the sequence
        public int m_seqtype; // type of sequence
        public string m_seq; // the raw stringified sequence as read from the xml
        public string Seqtype2string() 
        {
            switch (m_seqtype) 
            {
                case COMMAND_TYPE_GCODE: return "GCode Sequence";
                case COMMAND_TYPE_SCRIPT: return "Script Sequence";
                case COMMAND_TYPE_SPAWN_PROCESS: return "Process Sequence";
            }
            return "Unknown Sequence";
        }
    }

    public class GCodeSequence : CommandSequence
    {
        public GCodeSequence(string name, string seq)
        {
            m_seq = seq;
            m_name = name;
            m_seqtype = COMMAND_TYPE_GCODE;
        }
    }

}
