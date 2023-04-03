﻿// MIT License
//
// PointDataContainer.cs
//
// Copyright (c) 2022 Henning Rauch
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
//
// Author:
//       Andriy Kupershmidt <kuper133@googlemail.com>

#region Usings

using NoSQL.GraphDB.Core.Index.Spatial.Implementation.SpatialContainer;
using NoSQL.GraphDB.Core.Model;

#endregion

namespace NoSQL.GraphDB.Core.Index.Spatial.Implementation.RTree
{
    /// <summary>
    /// the realisation of point-container for the container with element of graph 
    /// </summary>
    public sealed class PointDataContainer : APointContainer, IRTreeDataContainer
    {
        public PointDataContainer(float[] point,
                          ARTreeContainer parent = null)
        {
            if (parent != null)
                Parent = parent;
            Coordinates = point;
        }
        public AGraphElementModel GraphElement
        {
            get;
            set;
        }

    }
}
