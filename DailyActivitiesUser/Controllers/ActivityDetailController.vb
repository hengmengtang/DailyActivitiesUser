Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace DailyActivitiesUser
    Public Class ActivityDetailController
        Inherits System.Web.Mvc.Controller

        Private db As New DailyActivityDBEntities

        ' GET: /ActivityDetail/
        Function Index() As ActionResult
            Dim activitydetails = db.ActivityDetails.Include(Function(a) a.Activity)
            Return View(activitydetails.ToList())
        End Function

        ' GET: /ActivityDetail/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activitydetail As ActivityDetail = db.ActivityDetails.Find(id)
            If IsNothing(activitydetail) Then
                Return HttpNotFound()
            End If
            Return View(activitydetail)
        End Function

        ' GET: /ActivityDetail/Create
        Function Create() As ActionResult
            ViewBag.act_id = New SelectList(db.Activities, "act_id", "act_id")
            Return View()
        End Function

        ' POST: /ActivityDetail/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "act_det_id,user_id,act_id,date,start_time,end_time,location,execute_status,description,cost")> ByVal activitydetail As ActivityDetail) As ActionResult
            If ModelState.IsValid Then
                db.ActivityDetails.Add(activitydetail)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.act_id = New SelectList(db.Activities, "act_id", "act_id", activitydetail.act_id)
            Return View(activitydetail)
        End Function

        ' GET: /ActivityDetail/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activitydetail As ActivityDetail = db.ActivityDetails.Find(id)
            If IsNothing(activitydetail) Then
                Return HttpNotFound()
            End If
            ViewBag.act_id = New SelectList(db.Activities, "act_id", "act_id", activitydetail.act_id)
            Return View(activitydetail)
        End Function

        ' POST: /ActivityDetail/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "act_det_id,user_id,act_id,date,start_time,end_time,location,execute_status,description,cost")> ByVal activitydetail As ActivityDetail) As ActionResult
            If ModelState.IsValid Then
                db.Entry(activitydetail).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.act_id = New SelectList(db.Activities, "act_id", "act_id", activitydetail.act_id)
            Return View(activitydetail)
        End Function

        ' GET: /ActivityDetail/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activitydetail As ActivityDetail = db.ActivityDetails.Find(id)
            If IsNothing(activitydetail) Then
                Return HttpNotFound()
            End If
            Return View(activitydetail)
        End Function

        ' POST: /ActivityDetail/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim activitydetail As ActivityDetail = db.ActivityDetails.Find(id)
            db.ActivityDetails.Remove(activitydetail)
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
