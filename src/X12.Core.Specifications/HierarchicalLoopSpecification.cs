﻿namespace X12.Core.Specifications
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using X12.Core.Specifications.Enumerations;
    using X12.Core.Specifications.Interfaces;

    [DebuggerStepThrough]
    [XmlType(AnonymousType = true)]
    public class HierarchicalLoopSpecification : IContainerSpecification
    {

        [XmlAttribute]
        public string LoopId { get; set; }

        [XmlAttribute]
        public string LevelCode { get; set; }

        [XmlAttribute]
        public Usage Usage { get; set; }

        public string Name { get; set; }

        [XmlElement(X12Elements.Segment)]
        public List<SegmentSpecification> SegmentSpecifications { get; set; }

        [XmlElement(X12Elements.Loop)]
        public List<LoopSpecification> LoopSpecifications { get; set; }

        [XmlElement(X12Elements.HierarchicalLoop)]
        public List<HierarchicalLoopSpecification> HierarchicalLoopSpecifications { get; set; }
    }
}
