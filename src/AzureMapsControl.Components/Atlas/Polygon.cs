﻿namespace AzureMapsControl.Components.Atlas
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    [ExcludeFromCodeCoverage]
    public sealed class Polygon : Geometry
    {
        public IEnumerable<IEnumerable<Position>> Coordinates { get; set; }
        public BoundingBox BBox { get; set; }

        public Polygon() : base() { }

        public Polygon(IEnumerable<IEnumerable<Position>> coordinates) : base(Guid.NewGuid().ToString()) => Coordinates = coordinates;

        public Polygon(IEnumerable<IEnumerable<Position>> coordinates, BoundingBox bbox) : this(coordinates) => BBox = bbox;

        public Polygon(string id) : base(id) { }

        public Polygon(string id, IEnumerable<IEnumerable<Position>> coordinates) : base(id) => Coordinates = coordinates;

        public Polygon(string id, IEnumerable<IEnumerable<Position>> coordinates, BoundingBox bbox) : this(id, coordinates) => BBox = bbox;

        internal override string GetGeometryType() => "Polygon";
    }
}
