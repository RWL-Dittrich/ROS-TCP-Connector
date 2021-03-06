//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Std;

namespace RosMessageTypes.Octomap
{
    public class OctomapWithPose : Message
    {
        public const string RosMessageName = "octomap_msgs/OctomapWithPose";

        //  A 3D map in binary format, as Octree
        public Header header;
        //  The pose of the octree with respect to the header frame 
        public Geometry.Pose origin;
        //  The actual octree msg
        public Octomap octomap;

        public OctomapWithPose()
        {
            this.header = new Header();
            this.origin = new Geometry.Pose();
            this.octomap = new Octomap();
        }

        public OctomapWithPose(Header header, Geometry.Pose origin, Octomap octomap)
        {
            this.header = header;
            this.origin = origin;
            this.octomap = octomap;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(header.SerializationStatements());
            listOfSerializations.AddRange(origin.SerializationStatements());
            listOfSerializations.AddRange(octomap.SerializationStatements());

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.header.Deserialize(data, offset);
            offset = this.origin.Deserialize(data, offset);
            offset = this.octomap.Deserialize(data, offset);

            return offset;
        }

        public override string ToString()
        {
            return "OctomapWithPose: " +
            "\nheader: " + header.ToString() +
            "\norigin: " + origin.ToString() +
            "\noctomap: " + octomap.ToString();
        }
    }
}
