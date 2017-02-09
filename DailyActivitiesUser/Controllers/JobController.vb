Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace DailyActivitiesUser
    Public Class JobController
        Inherits System.Web.Mvc.Controller

        Private db As New DailyActivityDBEntities

        ' GET: /Job/
        Function Index() As ActionResult
            Return View(db.Jobs.ToList())
        End Function

        ' GET: /Job/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim job As Job = db.Jobs.Find(id)
            If IsNothing(job) Then
                Return HttpNotFound()
            End If
            Return View(job)
        End Function

        ' GET: /Job/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /Job/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "job_id,jon_name")> ByVal job As Job) As ActionResult
            If ModelState.IsValid Then
                db.Jobs.Add(job)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(job)
        End Function

        ' GET: /Job/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim job As Job = db.Jobs.Find(id)
            If IsNothing(job) Then
                Return HttpNotFound()
            End If
            Return View(job)
        End Function

        ' POST: /Job/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "job_id,jon_name")> ByVal job As Job) As ActionResult
            If ModelState.IsValid Then
                db.Entry(job).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(job)
        End Function

        ' GET: /Job/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim job As Job = db.Jobs.Find(id)
            If IsNothing(job) Then
                Return HttpNotFound()
            End If
            Return View(job)
        End Function

        ' POST: /Job/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim job As Job = db.Jobs.Find(id)
            db.Jobs.Remove(job)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
