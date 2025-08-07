using System;

namespace Power_Focus_8
{
    public class OpenProtocolMessage
    {
        public int Length { get; set; }
        public int MID { get; set; }
        public int Revision { get; set; }
        public int NoAck { get; set; } // No Acknowledge flag
        public int StationID { get; set; }
        public int SpindleID { get; set; }
        public int SequenceNumber { get; set; }
        public int NumMessages { get; set; }
        public int MessageNumber { get; set; }
        public string Data { get; set; }

        public static OpenProtocolMessage Parse(string message)
        {
            if (string.IsNullOrEmpty(message) || message.Length < 20)
                return null;

            try
            {
                var msg = new OpenProtocolMessage
                {
                    Length = int.Parse(message.Substring(0, 4)),
                    MID = int.Parse(message.Substring(4, 4)),
                    Revision = int.Parse(message.Substring(8, 3)),
                    NoAck = int.Parse(message.Substring(11, 1)),
                    StationID = int.Parse(message.Substring(12, 2)),
                    SpindleID = int.Parse(message.Substring(14, 2)),
                    SequenceNumber = int.Parse(message.Substring(16, 2)),
                    NumMessages = int.Parse(message.Substring(18, 1)),
                    MessageNumber = int.Parse(message.Substring(19, 1)),
                    Data = message.Substring(20)
                };

                return msg;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string CreateMessage(int mid, int revision = 1, string data = "", int noAck = 0, int stationId = 0, int spindleId = 0, int sequenceNumber = 0, int numMessages = 0, int messageNumber = 0)
        {
            string messageData = data ?? "";
            int length = 22 + messageData.Length;

            return $"{length:D4}{mid:D4}{revision:D3}{noAck:D1}{stationId:D2}{spindleId:D2}{sequenceNumber:D4}{numMessages:D1}{messageNumber:D1}{messageData}";
        }
    }

    public class TighteningResult
    {
        public int CellId { get; set; }
        public int ChannelId { get; set; }
        public double TorqueValue { get; set; }
        public double AngleValue { get; set; }
        public int TighteningStatus { get; set; } // 0 = NOK, 1 = OK
        public DateTime Timestamp { get; set; }
        public int JobID { get; set; }
        public int TorqueStatus { get; set; } // 0 = Low, 1 = OK, 2 = High
        public int AngleStatus { get; set; } // 0 = Low, 1 = OK, 2 = High
    }
}