




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class MutationUpdate : GeneratedTest {

            public static Table tbl = r.db(DbName).table("tbl");
            public static Table tbl2 = r.db(DbName).table("tbl2");


        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #1
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':100}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 100);
                 
                 /* Original: tbl.insert([{'id':i} for i in xrange(100)]) */
                 var obtained = runOrCatch( tbl.insert(Enumerable.Range(0, 100).Select(i => r.hashMap("id", i)).ToList()) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #2
                 /* ExpectedOriginal: 100 */
                 var expected = 100;
                 
                 /* Original: tbl.count() */
                 var obtained = runOrCatch( tbl.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #3
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':100}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 100);
                 
                 /* Original: tbl2.insert([{'id':i, 'foo':{'bar':i}} for i in xrange(100)]) */
                 var obtained = runOrCatch( tbl2.insert(Enumerable.Range(0, 100).Select(i => r.hashMap("id", i).with("foo", r.hashMap("bar", i))).ToList()) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #4
                 /* ExpectedOriginal: 100 */
                 var expected = 100;
                 
                 /* Original: tbl2.count() */
                 var obtained = runOrCatch( tbl2.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #5
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':1,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("unchanged", 1).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.get(12).update(lambda row:row) */
                 var obtained = runOrCatch( tbl.get(12).update(row => row) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #6
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':1,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 1).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.get(12).update(lambda row:{'a':row['id'] + 1}, durability='soft') */
                 var obtained = runOrCatch( tbl.get(12).update(row => r.hashMap("a", row.g("id").add(1))).optArg("durability", "soft") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #7
                 /* ExpectedOriginal: ({'id':12, 'a':13}) */
                 var expected = r.hashMap("id", 12).with("a", 13);
                 
                 /* Original: tbl.get(12) */
                 var obtained = runOrCatch( tbl.get(12) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #8
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':1,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 1).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.get(12).update(lambda row:{'a':row['id'] + 2}, durability='hard') */
                 var obtained = runOrCatch( tbl.get(12).update(row => r.hashMap("a", row.g("id").add(2))).optArg("durability", "hard") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #9
                 /* ExpectedOriginal: ({'id':12, 'a':14}) */
                 var expected = r.hashMap("id", 12).with("a", 14);
                 
                 /* Original: tbl.get(12) */
                 var obtained = runOrCatch( tbl.get(12) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #10
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Durability option `wrong` unrecognized (options are "hard" and "soft").', [0]) */
                 var expected = err("ReqlQueryLogicError", "Durability option `wrong` unrecognized (options are \"hard\" and \"soft\").", r.array(0));
                 
                 /* Original: tbl.get(12).update(lambda row:{'a':row['id'] + 3}, durability='wrong') */
                 var obtained = runOrCatch( tbl.get(12).update(row => r.hashMap("a", row.g("id").add(3))).optArg("durability", "wrong") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #11
                 /* ExpectedOriginal: ({'id':12, 'a':14}) */
                 var expected = r.hashMap("id", 12).with("a", 14);
                 
                 /* Original: tbl.get(12) */
                 var obtained = runOrCatch( tbl.get(12) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #12
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':1,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 1).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.get(12).update(lambda row:{'a':row['id']}) */
                 var obtained = runOrCatch( tbl.get(12).update(row => r.hashMap("a", row.g("id"))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #13
                 /* ExpectedOriginal: ({'id':12, 'a':12}) */
                 var expected = r.hashMap("id", 12).with("a", 12);
                 
                 /* Original: tbl.get(12) */
                 var obtained = runOrCatch( tbl.get(12) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #14
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':1,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 1).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.get(12).update({'a':r.literal()}) */
                 var obtained = runOrCatch( tbl.get(12).update(r.hashMap("a", r.literal())) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #15
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':10,'unchanged':0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 10).with("unchanged", 0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.between(10, 20).update(lambda row:{'a':row['id']}) */
                 var obtained = runOrCatch( tbl.between(10, 20).update(row => r.hashMap("a", row.g("id"))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #16
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':10,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("unchanged", 10).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.filter(lambda row:(row['id'] >= 10) & (row['id'] < 20)).update(lambda row:{'a':row['id']}) */
                 var obtained = runOrCatch( tbl.filter(row => row.g("id").ge(10).and(row.g("id").lt(20))).update(row => r.hashMap("a", row.g("id"))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #17
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':10,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 10).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.filter(lambda row:(row['id'] >= 10) & (row['id'] < 20)).update(lambda row:{'b':row['id']}) */
                 var obtained = runOrCatch( tbl.filter(row => row.g("id").ge(10).and(row.g("id").lt(20))).update(row => r.hashMap("b", row.g("id"))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #18
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':10,'unchanged':0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 10).with("unchanged", 0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.between(10, 20).update({'a':r.literal()}) */
                 var obtained = runOrCatch( tbl.between(10, 20).update(r.hashMap("a", r.literal())) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #19
                 /* ExpectedOriginal: ({'first_error':'Primary key `id` cannot be changed (`{\n\t"id":\t1\n}` -> `{\n\t"d":\t1,\n\t"id":\t2\n}`).','deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':1,'skipped':0.0,'inserted':0.0}) */
                 var expected = r.hashMap("first_error", "Primary key `id` cannot be changed (`{\n\t\"id\":\t1\n}` -> `{\n\t\"d\":\t1,\n\t\"id\":\t2\n}`).").with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 1).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.get(1).update({'id':2,'d':1}) */
                 var obtained = runOrCatch( tbl.get(1).update(r.hashMap("id", 2).with("d", 1)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #22
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Could not prove argument deterministic.  Maybe you want to use the non_atomic flag?', [0]) */
                 var expected = err("ReqlQueryLogicError", "Could not prove argument deterministic.  Maybe you want to use the non_atomic flag?", r.array(0));
                 
                 /* Original: tbl.get(1).update({'d':r.js('5')}) */
                 var obtained = runOrCatch( tbl.get(1).update(r.hashMap("d", r.js("5"))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #23
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Could not prove argument deterministic.  Maybe you want to use the non_atomic flag?', [0]) */
                 var expected = err("ReqlQueryLogicError", "Could not prove argument deterministic.  Maybe you want to use the non_atomic flag?", r.array(0));
                 
                 /* Original: tbl.get(1).update({'d':tbl.nth(0)}) */
                 var obtained = runOrCatch( tbl.get(1).update(r.hashMap("d", tbl.nth(0))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #24
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':1,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 1).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.get(1).update({'d':r.js('5')}, non_atomic=True) */
                 var obtained = runOrCatch( tbl.get(1).update(r.hashMap("d", r.js("5"))).optArg("non_atomic", true) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #27
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':100,'unchanged':0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 100).with("unchanged", 0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.update(lambda row:{'a':row['id']}) */
                 var obtained = runOrCatch( tbl.update(row => r.hashMap("a", row.g("id"))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #28
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':100,'unchanged':0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 100).with("unchanged", 0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.update({'a':r.literal()}) */
                 var obtained = runOrCatch( tbl.update(r.hashMap("a", r.literal())) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #29
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':99,'unchanged':1,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 99).with("unchanged", 1).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl2.update({'foo':{'bar':2}}) */
                 var obtained = runOrCatch( tbl2.update(r.hashMap("foo", r.hashMap("bar", 2))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #30
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0,'unchanged':100,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 0).with("unchanged", 100).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl2.update({'foo':r.literal({'bar':2})}) */
                 var obtained = runOrCatch( tbl2.update(r.hashMap("foo", r.literal(r.hashMap("bar", 2)))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #32
                 /* ExpectedOriginal: ({'id':0,'foo':{'bar':2}}) */
                 var expected = r.hashMap("id", 0).with("foo", r.hashMap("bar", 2));
                 
                 /* Original: tbl2.order_by('id').nth(0) */
                 var obtained = runOrCatch( tbl2.orderBy("id").nth(0) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #33
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':100,'unchanged':0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 100).with("unchanged", 0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl2.update({'foo':{'buzz':2}}) */
                 var obtained = runOrCatch( tbl2.update(r.hashMap("foo", r.hashMap("buzz", 2))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #34
                 /* ExpectedOriginal: ({'id':0,'foo':{'bar':2,'buzz':2}}) */
                 var expected = r.hashMap("id", 0).with("foo", r.hashMap("bar", 2).with("buzz", 2));
                 
                 /* Original: tbl2.order_by('id').nth(0) */
                 var obtained = runOrCatch( tbl2.orderBy("id").nth(0) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #35
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':100,'unchanged':0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected = r.hashMap("deleted", 0.0).with("replaced", 100).with("unchanged", 0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl2.update({'foo':r.literal(1)}) */
                 var obtained = runOrCatch( tbl2.update(r.hashMap("foo", r.literal(1))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/update.yaml, #36
                 /* ExpectedOriginal: ({'id':0,'foo':1}) */
                 var expected = r.hashMap("id", 0).with("foo", 1);
                 
                 /* Original: tbl2.order_by('id').nth(0) */
                 var obtained = runOrCatch( tbl2.orderBy("id").nth(0) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             

        }
    }
}