














//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public partial class EqJoin : ReqlExpr {

    
    
    
/// <summary>
/// <para>Join tables using a field or function on the left-hand sequence matching primary keys or secondary indexes on the right-hand table. <code>eqJoin</code> is more efficient than other ReQL join types, and operates much faster. Documents in the result set consist of pairs of left-hand and right-hand documents, matched when the field on the left-hand side exists and is non-null and an entry with that field's value exists in the specified index on the right-hand side.</para>
/// <para>Example: Match players with the games they've played against one another.</para>
/// <para><code>js
/// r.table('players').eqJoin('gameId', r.table('games')).run(conn, callback)</code></para>
/// </summary>
/// <example></example>
        public EqJoin (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Join tables using a field or function on the left-hand sequence matching primary keys or secondary indexes on the right-hand table. <code>eqJoin</code> is more efficient than other ReQL join types, and operates much faster. Documents in the result set consist of pairs of left-hand and right-hand documents, matched when the field on the left-hand side exists and is non-null and an entry with that field's value exists in the specified index on the right-hand side.</para>
/// <para>Example: Match players with the games they've played against one another.</para>
/// <para><code>js
/// r.table('players').eqJoin('gameId', r.table('games')).run(conn, callback)</code></para>
/// </summary>
/// <example></example>
        public EqJoin (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Join tables using a field or function on the left-hand sequence matching primary keys or secondary indexes on the right-hand table. <code>eqJoin</code> is more efficient than other ReQL join types, and operates much faster. Documents in the result set consist of pairs of left-hand and right-hand documents, matched when the field on the left-hand side exists and is non-null and an entry with that field's value exists in the specified index on the right-hand side.</para>
/// <para>Example: Match players with the games they've played against one another.</para>
/// <para><code>js
/// r.table('players').eqJoin('gameId', r.table('games')).run(conn, callback)</code></para>
/// </summary>
/// <example></example>
        public EqJoin (Arguments args, OptArgs optargs)
         : base(TermType.EQ_JOIN, args, optargs) {
        }


    



    
///<summary>
/// "index": "T_STR"
///</summary>
        public EqJoin this[object optArgs] {
            get
            {
                var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
        
                return new EqJoin (this.Args, newOptArgs);
            }
        }
        
///<summary>
/// "index": "T_STR"
///</summary>
    public EqJoin this[OptArgs optArgs] {
        get
        {
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
    
            return new EqJoin (this.Args, newOptArgs);
        }
    }
    
///<summary>
/// "index": "T_STR"
///</summary>
        public EqJoin optArg(string key, object val){
            
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(key, val);
        
            return new EqJoin (this.Args, newOptArgs);
        }


    

    
        /// <summary>
        /// Get a single field from an object. If called on a sequence, gets that field from every object in the sequence, skipping objects that lack it.
        /// </summary>
        /// <param name="bracket"></param>
        public new Bracket this[string bracket] => base[bracket];
        
        /// <summary>
        /// Get the nth element of a sequence, counting from zero. If the argument is negative, count from the last element.
        /// </summary>
        /// <param name="bracket"></param>
        /// <returns></returns>
        public new Bracket this[int bracket] => base[bracket];


    

    


    
    }
}
