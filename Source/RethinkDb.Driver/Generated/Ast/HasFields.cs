














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

    public partial class HasFields : ReqlExpr {

    
    
    
/// <summary>
/// <para>Test if an object has one or more fields. An object has a field if it has that key and the key has a non-null value. For instance, the object <code>{'a': 1,'b': 2,'c': null}</code> has the fields <code>a</code> and <code>b</code>.</para>
/// </summary>
/// <example><para>Example: Return the players who have won games.</para>
/// <code>r.table('players').hasFields('games_won').run(conn, callback)
/// </code></example>
        public HasFields (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Test if an object has one or more fields. An object has a field if it has that key and the key has a non-null value. For instance, the object <code>{'a': 1,'b': 2,'c': null}</code> has the fields <code>a</code> and <code>b</code>.</para>
/// </summary>
/// <example><para>Example: Return the players who have won games.</para>
/// <code>r.table('players').hasFields('games_won').run(conn, callback)
/// </code></example>
        public HasFields (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Test if an object has one or more fields. An object has a field if it has that key and the key has a non-null value. For instance, the object <code>{'a': 1,'b': 2,'c': null}</code> has the fields <code>a</code> and <code>b</code>.</para>
/// </summary>
/// <example><para>Example: Return the players who have won games.</para>
/// <code>r.table('players').hasFields('games_won').run(conn, callback)
/// </code></example>
        public HasFields (Arguments args, OptArgs optargs)
         : base(TermType.HAS_FIELDS, args, optargs) {
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
