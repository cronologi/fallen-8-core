﻿// MIT License
//
// TransactionTest.cs
//
// Copyright (c) 2021 Henning Rauch
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

using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoSQL.GraphDB.App.Controllers.Sample;
using NoSQL.GraphDB.Core;
using NoSQL.GraphDB.Core.Expression;
using NoSQL.GraphDB.Core.Model;
using NoSQL.GraphDB.Core.Transaction;

namespace NoSQL.GraphDB.Tests
{
    [TestClass]
    public class TransactionTest
    {
        private readonly Fallen8 _fallen8 = new Fallen8();

        public TransactionTest()
        {
            
        }


        [TestMethod]
        public void AddVertex()
        {
            CreateVertexTransaction tx = new CreateVertexTransaction() { CreationDate = 1, Properties = null };

            var txId = _fallen8.EnqueueTransaction(tx);

            Thread.Sleep(10);

            int tries = 0;

            while (_fallen8.GetTransactionState(txId)!= TransactionState.Finished)
            {
                Thread.Sleep(1000);

                tries++;

                if (tries > 10)
                {
                    Assert.Fail();
                }
            }
        }
    }
}
