














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

    public partial class Get : ReqlExpr {

    
    
    
/// <summary>
/// <para>Get a document by primary key.</para>
/// <para>If no document exists with that primary key, <code>get</code> will return <code>null</code>.</para>
/// </summary>
/// <example><para>Example: Find a document by UUID.</para>
/// <code>r.table('posts').get('a9849eef-7176-4411-935b-79a6e3c56a74').run(conn, callback)
/// </code></example>
        public Get (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Get a document by primary key.</para>
/// <para>If no document exists with that primary key, <code>get</code> will return <code>null</code>.</para>
/// </summary>
/// <example><para>Example: Find a document by UUID.</para>
/// <code>r.table('posts').get('a9849eef-7176-4411-935b-79a6e3c56a74').run(conn, callback)
/// </code></example>
        public Get (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Get a document by primary key.</para>
/// <para>If no document exists with that primary key, <code>get</code> will return <code>null</code>.</para>
/// </summary>
/// <example><para>Example: Find a document by UUID.</para>
/// <code>r.table('posts').get('a9849eef-7176-4411-935b-79a6e3c56a74').run(conn, callback)
/// </code></example>
        public Get (Arguments args, OptArgs optargs)
         : base(TermType.GET, args, optargs) {
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
