//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from GameMakerLanguageParser.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="GameMakerLanguageParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public interface IGameMakerLanguageParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] GameMakerLanguageParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.statementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatementList([NotNull] GameMakerLanguageParser.StatementListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] GameMakerLanguageParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] GameMakerLanguageParser.BlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] GameMakerLanguageParser.IfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>DoStatement</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDoStatement([NotNull] GameMakerLanguageParser.DoStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>WhileStatement</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStatement([NotNull] GameMakerLanguageParser.WhileStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ForStatement</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForStatement([NotNull] GameMakerLanguageParser.ForStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>RepeatStatement</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRepeatStatement([NotNull] GameMakerLanguageParser.RepeatStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.withStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWithStatement([NotNull] GameMakerLanguageParser.WithStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.switchStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitchStatement([NotNull] GameMakerLanguageParser.SwitchStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.continueStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitContinueStatement([NotNull] GameMakerLanguageParser.ContinueStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.breakStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBreakStatement([NotNull] GameMakerLanguageParser.BreakStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.exitStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExitStatement([NotNull] GameMakerLanguageParser.ExitStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.emptyStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEmptyStatement([NotNull] GameMakerLanguageParser.EmptyStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.caseBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCaseBlock([NotNull] GameMakerLanguageParser.CaseBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.caseClauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCaseClauses([NotNull] GameMakerLanguageParser.CaseClausesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.caseClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCaseClause([NotNull] GameMakerLanguageParser.CaseClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.defaultClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefaultClause([NotNull] GameMakerLanguageParser.DefaultClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.throwStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitThrowStatement([NotNull] GameMakerLanguageParser.ThrowStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.tryStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTryStatement([NotNull] GameMakerLanguageParser.TryStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.catchProduction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCatchProduction([NotNull] GameMakerLanguageParser.CatchProductionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.finallyProduction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFinallyProduction([NotNull] GameMakerLanguageParser.FinallyProductionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnStatement([NotNull] GameMakerLanguageParser.ReturnStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.deleteStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeleteStatement([NotNull] GameMakerLanguageParser.DeleteStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.assignmentExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignmentExpression([NotNull] GameMakerLanguageParser.AssignmentExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.variableDeclarationList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclarationList([NotNull] GameMakerLanguageParser.VariableDeclarationListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.varModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarModifier([NotNull] GameMakerLanguageParser.VarModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.variableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclaration([NotNull] GameMakerLanguageParser.VariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.globalVarStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGlobalVarStatement([NotNull] GameMakerLanguageParser.GlobalVarStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.newExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewExpression([NotNull] GameMakerLanguageParser.NewExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IdentifierLValue</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.lValueStartExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierLValue([NotNull] GameMakerLanguageParser.IdentifierLValueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NewLValue</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.lValueStartExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewLValue([NotNull] GameMakerLanguageParser.NewLValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.lValueExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLValueExpression([NotNull] GameMakerLanguageParser.LValueExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MemberIndexLValue</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.lValueChainOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMemberIndexLValue([NotNull] GameMakerLanguageParser.MemberIndexLValueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MemberDotLValue</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.lValueChainOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMemberDotLValue([NotNull] GameMakerLanguageParser.MemberDotLValueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>CallLValue</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.lValueChainOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCallLValue([NotNull] GameMakerLanguageParser.CallLValueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MemberIndexLValueFinal</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.lValueFinalOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMemberIndexLValueFinal([NotNull] GameMakerLanguageParser.MemberIndexLValueFinalContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MemberDotLValueFinal</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.lValueFinalOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMemberDotLValueFinal([NotNull] GameMakerLanguageParser.MemberDotLValueFinalContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.expressionSequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpressionSequence([NotNull] GameMakerLanguageParser.ExpressionSequenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.expressionOrFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpressionOrFunction([NotNull] GameMakerLanguageParser.ExpressionOrFunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ParenthesizedExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesizedExpression([NotNull] GameMakerLanguageParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AdditiveExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdditiveExpression([NotNull] GameMakerLanguageParser.AdditiveExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>RelationalExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelationalExpression([NotNull] GameMakerLanguageParser.RelationalExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>TernaryExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTernaryExpression([NotNull] GameMakerLanguageParser.TernaryExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LogicalAndExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicalAndExpression([NotNull] GameMakerLanguageParser.LogicalAndExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BitNotExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBitNotExpression([NotNull] GameMakerLanguageParser.BitNotExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LiteralExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralExpression([NotNull] GameMakerLanguageParser.LiteralExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LogicalOrExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicalOrExpression([NotNull] GameMakerLanguageParser.LogicalOrExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VariableExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableExpression([NotNull] GameMakerLanguageParser.VariableExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NotExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNotExpression([NotNull] GameMakerLanguageParser.NotExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>UnaryMinusExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryMinusExpression([NotNull] GameMakerLanguageParser.UnaryMinusExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BitAndExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBitAndExpression([NotNull] GameMakerLanguageParser.BitAndExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LogicalXorExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicalXorExpression([NotNull] GameMakerLanguageParser.LogicalXorExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BitOrExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBitOrExpression([NotNull] GameMakerLanguageParser.BitOrExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IncDecExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIncDecExpression([NotNull] GameMakerLanguageParser.IncDecExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>EqualityExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEqualityExpression([NotNull] GameMakerLanguageParser.EqualityExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BitXOrExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBitXOrExpression([NotNull] GameMakerLanguageParser.BitXOrExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>CallExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCallExpression([NotNull] GameMakerLanguageParser.CallExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MultiplicativeExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplicativeExpression([NotNull] GameMakerLanguageParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>CoalesceExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCoalesceExpression([NotNull] GameMakerLanguageParser.CoalesceExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BitShiftExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBitShiftExpression([NotNull] GameMakerLanguageParser.BitShiftExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.callStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCallStatement([NotNull] GameMakerLanguageParser.CallStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.callableExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCallableExpression([NotNull] GameMakerLanguageParser.CallableExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PreIncDecExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.incDecStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPreIncDecExpression([NotNull] GameMakerLanguageParser.PreIncDecExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PostIncDecExpression</c>
	/// labeled alternative in <see cref="GameMakerLanguageParser.incDecStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPostIncDecExpression([NotNull] GameMakerLanguageParser.PostIncDecExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.accessor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAccessor([NotNull] GameMakerLanguageParser.AccessorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArguments([NotNull] GameMakerLanguageParser.ArgumentsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.assignmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignmentOperator([NotNull] GameMakerLanguageParser.AssignmentOperatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteral([NotNull] GameMakerLanguageParser.LiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.templateStringLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTemplateStringLiteral([NotNull] GameMakerLanguageParser.TemplateStringLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.templateStringAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTemplateStringAtom([NotNull] GameMakerLanguageParser.TemplateStringAtomContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.arrayLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayLiteral([NotNull] GameMakerLanguageParser.ArrayLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.elementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElementList([NotNull] GameMakerLanguageParser.ElementListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.structLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructLiteral([NotNull] GameMakerLanguageParser.StructLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPropertyAssignment([NotNull] GameMakerLanguageParser.PropertyAssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.propertyIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPropertyIdentifier([NotNull] GameMakerLanguageParser.PropertyIdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.functionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDeclaration([NotNull] GameMakerLanguageParser.FunctionDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.constructorClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructorClause([NotNull] GameMakerLanguageParser.ConstructorClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterList([NotNull] GameMakerLanguageParser.ParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.parameterArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterArgument([NotNull] GameMakerLanguageParser.ParameterArgumentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] GameMakerLanguageParser.IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.enumeratorDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumeratorDeclaration([NotNull] GameMakerLanguageParser.EnumeratorDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.enumeratorList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumeratorList([NotNull] GameMakerLanguageParser.EnumeratorListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.enumerator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumerator([NotNull] GameMakerLanguageParser.EnumeratorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.macroStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacroStatement([NotNull] GameMakerLanguageParser.MacroStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.defineStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefineStatement([NotNull] GameMakerLanguageParser.DefineStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.regionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRegionStatement([NotNull] GameMakerLanguageParser.RegionStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.identifierStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierStatement([NotNull] GameMakerLanguageParser.IdentifierStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.softKeyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSoftKeyword([NotNull] GameMakerLanguageParser.SoftKeywordContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.propertySoftKeyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPropertySoftKeyword([NotNull] GameMakerLanguageParser.PropertySoftKeywordContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.openBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpenBlock([NotNull] GameMakerLanguageParser.OpenBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.closeBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCloseBlock([NotNull] GameMakerLanguageParser.CloseBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.eos"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEos([NotNull] GameMakerLanguageParser.EosContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GameMakerLanguageParser.macroToken"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacroToken([NotNull] GameMakerLanguageParser.MacroTokenContext context);
}
