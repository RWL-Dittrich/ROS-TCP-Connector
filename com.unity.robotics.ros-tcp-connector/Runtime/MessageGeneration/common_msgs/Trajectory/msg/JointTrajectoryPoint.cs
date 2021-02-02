//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using RosMessageGeneration;
using RosMessageTypes.Std;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Trajectory
{
    public class JointTrajectoryPoint : Message
    {
        public const string RosMessageName = "trajectory_msgs/JointTrajectoryPoint";

        //  Each trajectory point specifies either positions[, velocities[, accelerations]]
        //  or positions[, effort] for the trajectory to be executed.
        //  All specified values are in the same order as the joint names in JointTrajectory.msg
        public double[] positions;
        public double[] velocities;
        public double[] accelerations;
        public double[] effort;
        public Duration time_from_start;

        public JointTrajectoryPoint()
        {
            this.positions = new double[0];
            this.velocities = new double[0];
            this.accelerations = new double[0];
            this.effort = new double[0];
            this.time_from_start = new Duration();
        }

        public JointTrajectoryPoint(double[] positions, double[] velocities, double[] accelerations, double[] effort, Duration time_from_start)
        {
            this.positions = positions;
            this.velocities = velocities;
            this.accelerations = accelerations;
            this.effort = effort;
            this.time_from_start = time_from_start;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            
            listOfSerializations.Add(BitConverter.GetBytes(positions.Length));
            foreach(var entry in positions)
                listOfSerializations.Add(BitConverter.GetBytes(entry));
            
            listOfSerializations.Add(BitConverter.GetBytes(velocities.Length));
            foreach(var entry in velocities)
                listOfSerializations.Add(BitConverter.GetBytes(entry));
            
            listOfSerializations.Add(BitConverter.GetBytes(accelerations.Length));
            foreach(var entry in accelerations)
                listOfSerializations.Add(BitConverter.GetBytes(entry));
            
            listOfSerializations.Add(BitConverter.GetBytes(effort.Length));
            foreach(var entry in effort)
                listOfSerializations.Add(BitConverter.GetBytes(entry));
            listOfSerializations.AddRange(time_from_start.SerializationStatements());

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            
            var positionsArrayLength = DeserializeLength(data, offset);
            offset += 4;
            this.positions= new double[positionsArrayLength];
            for(var i = 0; i < positionsArrayLength; i++)
            {
                this.positions[i] = BitConverter.ToDouble(data, offset);
                offset += 8;
            }
            
            var velocitiesArrayLength = DeserializeLength(data, offset);
            offset += 4;
            this.velocities= new double[velocitiesArrayLength];
            for(var i = 0; i < velocitiesArrayLength; i++)
            {
                this.velocities[i] = BitConverter.ToDouble(data, offset);
                offset += 8;
            }
            
            var accelerationsArrayLength = DeserializeLength(data, offset);
            offset += 4;
            this.accelerations= new double[accelerationsArrayLength];
            for(var i = 0; i < accelerationsArrayLength; i++)
            {
                this.accelerations[i] = BitConverter.ToDouble(data, offset);
                offset += 8;
            }
            
            var effortArrayLength = DeserializeLength(data, offset);
            offset += 4;
            this.effort= new double[effortArrayLength];
            for(var i = 0; i < effortArrayLength; i++)
            {
                this.effort[i] = BitConverter.ToDouble(data, offset);
                offset += 8;
            }
            offset = this.time_from_start.Deserialize(data, offset);

            return offset;
        }

        public override string ToString()
        {
            return "JointTrajectoryPoint: " +
            "\npositions: " + System.String.Join(", ", positions.ToList()) +
            "\nvelocities: " + System.String.Join(", ", velocities.ToList()) +
            "\naccelerations: " + System.String.Join(", ", accelerations.ToList()) +
            "\neffort: " + System.String.Join(", ", effort.ToList()) +
            "\ntime_from_start: " + time_from_start.ToString();
        }
    }
}