﻿// using System;
// using NUnit.Framework;
// using skycoin;
// using utils;
// namespace LibskycoinNetTest {
//     [TestFixture ()]
//     public class check_util_fee : skycoin.skycoin{

//         utils.transutils transutils = new utils.transutils ();
//         struct verifyTxFeeTestCase {
//             public ulong inputHours;
//             public ulong ouputHours;
//             public int err;
//         }
//         verifyTxFeeTestCase[] burnFactor2verifyTxFeeTestCase = new verifyTxFeeTestCase[15];

//         public void FullburnFactor2verifyTxFeeTestCase () {

//             verifyTxFeeTestCase cases = new verifyTxFeeTestCase ();
//             cases.inputHours = 0;
//             cases.ouputHours = 0;
//             cases.err = SKY_ErrTxnNoFee;
//             burnFactor2verifyTxFeeTestCase[0] = cases;

//             cases = new verifyTxFeeTestCase ();
//             cases.inputHours = 1;
//             cases.ouputHours = 0;
//             cases.err = SKY_OK;
//             burnFactor2verifyTxFeeTestCase[1] = cases;

//             cases = new verifyTxFeeTestCase ();
//             cases.inputHours = 1;
//             cases.ouputHours = 1;
//             cases.err = SKY_ErrTxnNoFee;
//             burnFactor2verifyTxFeeTestCase[2] = cases;

//             cases = new verifyTxFeeTestCase ();
//             cases.inputHours = 2;
//             cases.ouputHours = 0;
//             cases.err = SKY_OK;
//             burnFactor2verifyTxFeeTestCase[3] = cases;

//             cases = new verifyTxFeeTestCase ();
//             cases.inputHours = 2;
//             cases.ouputHours = 1;
//             cases.err = SKY_OK;
//             burnFactor2verifyTxFeeTestCase[4] = cases;

//             cases = new verifyTxFeeTestCase ();
//             cases.inputHours = 2;
//             cases.ouputHours = 2;
//             cases.err = SKY_ErrTxnNoFee;
//             burnFactor2verifyTxFeeTestCase[5] = cases;

//             cases = new verifyTxFeeTestCase ();
//             cases.inputHours = 3;
//             cases.ouputHours = 0;
//             cases.err = SKY_OK;
//             burnFactor2verifyTxFeeTestCase[6] = cases;

//             cases = new verifyTxFeeTestCase ();
//             cases.inputHours = 3;
//             cases.ouputHours = 1;
//             cases.err = SKY_OK;
//             burnFactor2verifyTxFeeTestCase[7] = cases;

//             cases = new verifyTxFeeTestCase ();
//             cases.inputHours = 3;
//             cases.ouputHours = 2;
//             cases.err = SKY_ErrTxnInsufficientFee;
//             burnFactor2verifyTxFeeTestCase[8] = cases;

//             cases = new verifyTxFeeTestCase ();
//             cases.inputHours = 3;
//             cases.ouputHours = 3;
//             cases.err = SKY_ErrTxnNoFee;
//             burnFactor2verifyTxFeeTestCase[9] = cases;

//             cases = new verifyTxFeeTestCase ();
//             cases.inputHours = 4;
//             cases.ouputHours = 0;
//             cases.err = SKY_OK;
//             burnFactor2verifyTxFeeTestCase[10] = cases;

//             cases = new verifyTxFeeTestCase ();
//             cases.inputHours = 4;
//             cases.ouputHours = 1;
//             cases.err = SKY_OK;
//             burnFactor2verifyTxFeeTestCase[11] = cases;

//             cases = new verifyTxFeeTestCase ();
//             cases.inputHours = 4;
//             cases.ouputHours = 2;
//             cases.err = SKY_OK;
//             burnFactor2verifyTxFeeTestCase[12] = cases;

//             cases = new verifyTxFeeTestCase ();
//             cases.inputHours = 4;
//             cases.ouputHours = 3;
//             cases.err = SKY_ErrTxnInsufficientFee;
//             burnFactor2verifyTxFeeTestCase[13] = cases;

//             cases = new verifyTxFeeTestCase ();
//             cases.inputHours = 4;
//             cases.ouputHours = 4;
//             cases.err = SKY_ErrTxnNoFee;
//             burnFactor2verifyTxFeeTestCase[14] = cases;
//         }

//         [Test]
//         public void TestVerifyTransactionFee () {
//             FullburnFactor2verifyTxFeeTestCase ();
//             var empty = transutils.makeEmptyTransaction ();
//             var hours = new_GoUint64p ();
//             var err = SKY_coin_Transaction_OutputHours (empty, hours);
//             Assert.AreEqual (err, SKY_OK);
//             Assert.AreEqual (GoUint64p_value (hours), 0);

//             // A txn with no outputs hours and no coinhours burn fee is valid
//             err = SKY_fee_VerifyTransactionFee (empty, 0,2);
//             Assert.AreEqual (err, SKY_ErrTxnNoFee);

//             // A txn with no outputs hours but with a coinhours burn fee is valid
//             err = SKY_fee_VerifyTransactionFee (empty, 100,2);
//             Assert.AreEqual (err, SKY_OK);
//             var txn = transutils.makeEmptyTransaction ();
//             var addr = new cipher__Address ();
//             addr = transutils.makeAddress ();
//             Assert.AreEqual (err, 0);
//             err = SKY_coin_Transaction_PushOutput (txn, addr, 0, 1000000);
//             Assert.AreEqual (err, SKY_OK);
//             err = SKY_coin_Transaction_PushOutput (txn, addr, 0, 3000000);
//             Assert.AreEqual (err, SKY_OK);
//             err = SKY_coin_Transaction_OutputHours (txn, hours);
//             Assert.AreEqual (err, SKY_OK);
//             Assert.AreEqual (GoUint64p_value (hours), 4000000);

//             // A txn with insufficient net coinhours burn fee is invalid
//             err = SKY_fee_VerifyTransactionFee (txn, 0,2);
//             Assert.AreEqual (err, SKY_ErrTxnNoFee);
//             err = SKY_fee_VerifyTransactionFee (txn, 1,2);
//             Assert.AreEqual (err, SKY_ErrTxnInsufficientFee);

//             // A txn with sufficient net coinhours burn fee is valid
//             err = SKY_coin_Transaction_OutputHours (txn, hours);
//             Assert.AreEqual (err, SKY_OK);
//             err = SKY_fee_VerifyTransactionFee (txn, GoUint64p_value (hours),2);
//             Assert.AreEqual (err, SKY_OK);
//             err = SKY_coin_Transaction_OutputHours (txn, hours);
//             Assert.AreEqual (err, SKY_OK);
//             err = SKY_fee_VerifyTransactionFee (txn, ((ulong) (GoUint64p_value (hours) * 10)),2);
//             Assert.AreEqual (err, SKY_OK);

//             // fee + hours overflows
//             err = SKY_fee_VerifyTransactionFee (txn, ((ulong.MaxValue - 3000000)),2);
//             Assert.AreEqual (err, SKY_ERROR);

//             // txn has overflowing output hours
//             err = SKY_coin_Transaction_PushOutput (txn, addr, 0,
//                 (ulong.MaxValue - 1000000 - 3000000 + 1));
//             Assert.AreEqual (err, SKY_OK, "txn has overflowing output hours");
//             err = SKY_fee_VerifyTransactionFee (txn, 10,2);
//             Assert.AreEqual (err, SKY_ERROR, "SKY_fee_VerifyTransactionFee failed");

//             int len = burnFactor2verifyTxFeeTestCase.Length;
//             for (int i = 0; i < len; i++) {
//                 txn = new_Transaction__Handlep ();
//                 txn = transutils.makeEmptyTransaction ();
//                 verifyTxFeeTestCase tc = burnFactor2verifyTxFeeTestCase[i];
//                 err = SKY_coin_Transaction_PushOutput (txn, addr, 0, tc.ouputHours);
//                 Assert.AreEqual (err, SKY_OK);
//                 Assert.IsTrue (tc.inputHours >= tc.ouputHours);
//                 err = SKY_fee_VerifyTransactionFee (txn, (ulong) (tc.inputHours - tc.ouputHours),2);
//                 Assert.AreEqual (tc.err, err, "Iter " + i.ToString () + " is " + tc.err.ToString () + " != " + err.ToString ());;
//             }
//         }
//         struct requiredFeeTestCase {
//             public ulong hours;
//             public ulong fee;
//         }
//         requiredFeeTestCase[] burnFactor2verifyTxFeeTestCase2 = new requiredFeeTestCase[12];
//         public void FullburnFactor2RequiredFeeTestCases2 () {
//             var cases = new requiredFeeTestCase ();
//             cases.hours = 0;
//             cases.fee = 0;
//             burnFactor2verifyTxFeeTestCase2[0] = cases;
//             cases = new requiredFeeTestCase ();
//             cases.hours = 1;
//             cases.fee = 1;
//             burnFactor2verifyTxFeeTestCase2[1] = cases;
//             cases = new requiredFeeTestCase ();
//             cases.hours = 2;
//             cases.fee = 1;
//             burnFactor2verifyTxFeeTestCase2[2] = cases;
//             cases = new requiredFeeTestCase ();
//             cases.hours = 3;
//             cases.fee = 2;
//             burnFactor2verifyTxFeeTestCase2[3] = cases;
//             cases = new requiredFeeTestCase ();
//             cases.hours = 4;
//             cases.fee = 2;
//             burnFactor2verifyTxFeeTestCase2[4] = cases;
//             cases = new requiredFeeTestCase ();
//             cases.hours = 5;
//             cases.fee = 3;
//             burnFactor2verifyTxFeeTestCase2[5] = cases;
//             cases = new requiredFeeTestCase ();
//             cases.hours = 6;
//             cases.fee = 3;
//             burnFactor2verifyTxFeeTestCase2[6] = cases;
//             cases = new requiredFeeTestCase ();
//             cases.hours = 7;
//             cases.fee = 4;
//             burnFactor2verifyTxFeeTestCase2[7] = cases;
//             cases = new requiredFeeTestCase ();
//             cases.hours = 998;
//             cases.fee = 499;
//             burnFactor2verifyTxFeeTestCase2[8] = cases;
//             cases = new requiredFeeTestCase ();
//             cases.hours = 999;
//             cases.fee = 500;
//             burnFactor2verifyTxFeeTestCase2[9] = cases;
//             cases = new requiredFeeTestCase ();
//             cases.hours = 1000;
//             cases.fee = 500;
//             burnFactor2verifyTxFeeTestCase2[10] = cases;
//             cases = new requiredFeeTestCase ();
//             cases.hours = 1001;
//             cases.fee = 501;
//             burnFactor2verifyTxFeeTestCase2[11] = cases;
//         }

//         [Test]
//         public void TestRequiredFee () {
//             FullburnFactor2RequiredFeeTestCases2 ();
//             var cases = burnFactor2verifyTxFeeTestCase2;

//             for (int i = 0; i < cases.Length; i++) {
//                 var tc = cases[i];
//                 var fee = new_GoUint64p ();
//                 var err = SKY_fee_RequiredFee (tc.hours,2, fee);
//                 Assert.AreEqual (err, SKY_OK);
//                 Assert.AreEqual (tc.fee, GoUint64p_value (fee));
//                 var remainingHours = new_GoUint64p ();
//                 err = SKY_fee_RemainingHours (tc.hours,2, remainingHours);
//                 Assert.AreEqual (err, SKY_OK);
//                 Assert.AreEqual (tc.hours - GoUint64p_value (fee), GoUint64p_value (remainingHours));
//             }
//         }

//         struct uxInput {
//             public ulong time;
//             public ulong coins;
//             public ulong hours;
//         }
//         struct StrTest {
//             public ulong[] outs;
//             public uxInput[] ins;
//             public ulong headTime;
//             public ulong fee;
//             public int err;
//         }
//         StrTest[] ListCases = new StrTest[6];
//         public void FullCases () {

//             ulong headTime = 1000;
//             ulong nextTime = (headTime + 3600); //1 hour later

//             var cases = new StrTest ();
//             cases.fee = 5;
//             cases.outs = new ulong[1];
//             cases.outs[0] = 5;
//             cases.ins = new uxInput[1];
//             cases.ins[0].time = headTime;
//             cases.ins[0].coins = (ulong) 10e6;
//             cases.ins[0].hours = (ulong) 10;
//             cases.headTime = headTime;
//             ListCases[0] = cases;

//             cases = new StrTest ();
//             cases.fee = 0;
//             cases.outs = new ulong[3];
//             cases.outs[0] = 5;
//             cases.outs[1] = 7;
//             cases.outs[2] = 3;
//             cases.ins = new uxInput[2];
//             cases.ins[0].time = headTime;
//             cases.ins[0].coins = (ulong) 10e6;
//             cases.ins[0].hours = (ulong) 10;
//             cases.ins[1].time = headTime;
//             cases.ins[1].coins = (ulong) 10e6;
//             cases.ins[1].hours = (ulong) 5;
//             cases.headTime = headTime;
//             ListCases[1] = cases;

//             cases = new StrTest ();
//             cases.fee = 8;
//             cases.outs = new ulong[2];
//             cases.outs[0] = 5;
//             cases.outs[1] = 10;
//             cases.ins = new uxInput[2];
//             cases.ins[0].time = nextTime;
//             cases.ins[0].coins = (ulong) 10e6;
//             cases.ins[0].hours = (ulong) 10;
//             cases.ins[1].time = headTime;
//             cases.ins[1].coins = (ulong) 8e6;
//             cases.ins[1].hours = (ulong) 5;
//             cases.headTime = nextTime;
//             ListCases[2] = cases;

//             cases = new StrTest ();
//             cases.err = SKY_ErrTxnInsufficientCoinHours;
//             cases.outs = new ulong[3];
//             cases.outs[0] = 5;
//             cases.outs[1] = 10;
//             cases.outs[2] = 1;
//             cases.ins = new uxInput[2];
//             cases.ins[0].time = headTime;
//             cases.ins[0].coins = (ulong) 10e6;
//             cases.ins[0].hours = (ulong) 10;
//             cases.ins[1].time = headTime;
//             cases.ins[1].coins = (ulong) 8e6;
//             cases.ins[1].hours = (ulong) 5;
//             cases.headTime = headTime;
//             ListCases[3] = cases;

//             cases = new StrTest ();
//             cases.err = SKY_ErrAddEarnedCoinHoursAdditionOverflow;
//             cases.outs = new ulong[1];
//             cases.outs[0] = 0;
//             cases.ins = new uxInput[2];
//             cases.ins[0].time = headTime;
//             cases.ins[0].coins = (ulong) 10e6;
//             cases.ins[0].hours = (ulong) 10;
//             cases.ins[1].time = headTime;
//             cases.ins[1].coins = (ulong) 10e6;
//             cases.ins[1].hours = (ulong.MaxValue - 9);
//             cases.headTime = nextTime;
//             ListCases[4] = cases;

//             cases = new StrTest ();
//             cases.err = SKY_ERROR;
//             cases.outs = new ulong[3];
//             cases.outs[0] = 0;
//             cases.outs[1] = 10;
//             cases.outs[2] = ulong.MaxValue - 9;
//             cases.ins = new uxInput[2];
//             cases.ins[0].time = headTime;
//             cases.ins[0].coins = (ulong) 10e6;
//             cases.ins[0].hours = (ulong) 10;
//             cases.ins[1].time = headTime;
//             cases.ins[1].coins = (ulong) 10e6;
//             cases.ins[1].hours = (ulong) 100;
//             cases.headTime = headTime;
//             ListCases[5] = cases;
//         }

//         [Test]
//         public void TestTransactionFee () {
//             FullCases ();
//             var addr = transutils.makeAddress ();
//             for (int i = 0; i < ListCases.Length; i++) {
//                 var tc = ListCases[i];
//                 var tx = transutils.makeEmptyTransaction ();
//                 for (int j = 0; j < tc.outs.Length; j++) {
//                     var h = tc.outs[j];
//                     var err1 = SKY_coin_Transaction_PushOutput (tx, addr, (ulong) 0, (ulong) h);
//                     Assert.AreEqual (err1, SKY_OK);
//                 }
//                 var inUxs = transutils.makeUxOutArray (tc.ins.Length);
//                 Assert.AreEqual (inUxs.count, tc.ins.Length);
//                 for (int j = 0; j < tc.ins.Length; j++) {
//                     uxInput b = tc.ins[j];
//                     coin__UxOut ux = new coin__UxOut ();
//                     ux.Head.Time = b.time;
//                     ux.Body.Coins = b.coins;
//                     ux.Body.Hours = b.hours;
//                     inUxs.setAt (j, ux);
//                 }
//                 var fee = new_GoUint64p ();
//                 var err = SKY_fee_TransactionFee (tx, tc.headTime, inUxs, fee);
//                 Assert.AreEqual (err, tc.err);
//                 var fee_v = GoUint64p_value (fee);
//                 Assert.AreEqual (fee_v, tc.fee);
//             }
//         }
//     }
// }