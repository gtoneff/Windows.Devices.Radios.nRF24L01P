﻿namespace Windows.Devices.Radios.nRF24L01P.Registers
{
    /// <summary>
    ///   Number of bytes in RX payload in data pipe 2
    /// </summary>
    public class ReceivePayloadWidthPipe2Register : RegisterBase
    {
        public ReceivePayloadWidthPipe2Register(Radio radio) : base(radio, 1, Addresses.RX_PW_P2)
        {

        }

        public byte RX_PW_P2
        {
            get { return GetByteValue(5, Properties.RX_PW_P2); }
            set { SetByteValue(value, 5, Properties.RX_PW_P2); }
        }
    }
}
