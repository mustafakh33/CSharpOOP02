using CSharpOOP02.@class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP02.@class 
{
    public class DeliveryCenter
    {
        private string _centerName = string.Empty;
        private Shipment[] _shipments;
        public DeliveryCenter()
        {
            _shipments = new Shipment[20];
        }

        public DeliveryCenter(string centerName) : this()
        {
            CenterName = centerName;
        }

        public string CenterName
        {
            get => _centerName;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _centerName = value;
                }
            }
        }

        // Indexer by index
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < _shipments.Length)
                {
                    return _shipments[index];
                }

                return default;
            }

            set
            {
                if (index >= 0 && index < _shipments.Length)
                {
                    _shipments[index] = value;
                }
            }
        }

        // Indexer by tracking code
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < _shipments.Length; i++)
                {
                    if (_shipments[i] != null && _shipments[i].TrackingCode == trackingCode)
                    {
                        return _shipments[i];
                    }
                }
                return default;
            }
        }

        // AddShipment method
        public bool AddShipment(Shipment shipment)
        {
            if (shipment == null)
            {
                return false;
            }
            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] == null)
                {
                    _shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        // RemoveShipment method
        public bool RemoveShipment(string trackingCode)
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
            {
                return false;
            }
            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i].TrackingCode == trackingCode)
                {
                    _shipments[i] = null;
                    return true;
                }
            }
            return false;
        }

        // PrintAllShipments method
        public void PrintAllShipments()
        {
            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] != null)
                {
                    Console.WriteLine($"Shipment {i + 1}:");
                    Console.WriteLine($"Tracking Code: {_shipments[i].TrackingCode}");
                    Console.WriteLine($"Description: {_shipments[i].Description}");
                    Console.WriteLine($"Weight: {_shipments[i].Weight}");
                    Console.WriteLine($"Delivery Fee: {_shipments[i].DeliveryFee}");
                    Console.WriteLine($"Destination: {_shipments[i].Destination}");
                    Console.WriteLine($"Estimated Cost: {_shipments[i].EstimatedCost}");
                    Console.WriteLine();
                }
            }
        }

    }
}
