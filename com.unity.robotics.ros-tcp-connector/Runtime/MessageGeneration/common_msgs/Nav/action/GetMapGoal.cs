//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Nav
{
    public class GetMapGoal : Message
    {
        public const string RosMessageName = "nav_msgs/GetMap";

        //  Get the map as a nav_msgs/OccupancyGrid

        public GetMapGoal()
        {
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {

            return offset;
        }

        public override string ToString()
        {
            return "GetMapGoal: ";
        }
    }
}
