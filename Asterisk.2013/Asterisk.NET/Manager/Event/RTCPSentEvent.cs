using System;
using System.Collections.Generic;
using System.Text;

namespace AsterNET.Manager.Event
{
	public class RTCPSentEvent : ManagerEvent
	{
        public int ChannelState { get; set; }
        public string ChannelStateDesc { get; set; }
        public string CallerIDNum { get; set; }
        public string CallerIDName { get; set; }
        public string ConnectedLineNum { get; set; }
        public string ConnectedLineName { get; set; }
        public string Language { get; set; }
        public string AccountCode { get; set; }
        public string Context { get; set; }
        public string Exten { get; set; }
        public string Priority { get; set; }
        public string Linkedid { get; set; }
		
        /// <summary>
        /// The SSRC identifier for the remote system
        /// </summary>
        public string SSRC { get; set; }

        /// <summary>
        /// The type of packet for this RTCP report. 200(SR) 201(RR)
        /// </summary>
        public string PT { get; set; }

        /// <summary>
        /// The address the report was received from.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// The address the report was sent to.
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// The number of reports that were received.
        /// The report count determines the number of ReportX headers in the message. The X for each set of report headers will range from 0 to ReportCount - 1.
        /// </summary>
        public int ReportCount { get; set; }

        /// <summary>
        /// The time the sender generated the report. Only valid when PT is 200(SR).
        /// </summary>
        public decimal SentNTP { get; set; }

        /// <summary>
        /// The sender's last RTP timestamp. Only valid when PT is 200(SR).
        /// </summary>
        public long SentRTP { get; set; }

        /// <summary>
        /// The number of packets the sender has sent. Only valid when PT is 200(SR).
        /// </summary>
        public long SentPackets { get; set; }

        /// <summary>
        /// The number of bytes the sender has sent. Only valid when PT is 200(SR).
        /// </summary>
        public long SentOctets { get; set; }

		#region Constructor - RTCPSentEvent(ManagerConnection source)
		public RTCPSentEvent(ManagerConnection source)
			: base(source)
		{
		}
		#endregion
	}
}
