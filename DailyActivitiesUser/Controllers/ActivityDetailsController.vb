Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports DailyActivitiesUser

Namespace Controllers
    Public Class ActivityDetailsController
        Inherits System.Web.Mvc.Controller

        Private db As New DailyActivityDBEntities1

        ' GET: ActivityDetails
        Function Index() As ActionResult
            Dim activityDetails = db.ActivityDetails.Include(Function(a) a.Activity).Include(Function(a) a.UserAccount)
            Return View(activityDetails.ToList())
        End Function

        ' GET: ActivityDetails/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activityDetail As ActivityDetail = db.ActivityDetails.Find(id)
            If IsNothing(activityDetail) Then
                Return HttpNotFound()
            End If
            Return View(activityDetail)
        End Function

        ' GET: ActivityDetails/Create
        Function Create() As ActionResult
            ViewBag.act_id = New SelectList(db.Activities, "act_id", "act_id")
            ViewBag.user_id = New SelectList(db.UserAccounts, "user_id", "first_name")
            Return View()
        End Function

        ' POST: ActivityDetails/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="act_det_id,user_id,act_id,date,start_time,end_time,location,execute_status,description,cost")> ByVal activityDetail As ActivityDetail) As ActionResult
            If ModelState.IsValid Then
                db.ActivityDetails.Add(activityDetail)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.act_id = New SelectList(db.Activities, "act_id", "act_id", activityDetail.act_id)
            ViewBag.user_id = New SelectList(db.UserAccounts, "user_id", "first_name", activityDetail.user_id)
            Return View(activityDetail)
        End Function

        ' GET: ActivityDetails/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activityDetail As ActivityDetail = db.ActivityDetails.Find(id)
            If IsNothing(activityDetail) Then
                Return HttpNotFound()
            End If
            ViewBag.act_id = New SelectList(db.Activities, "act_id", "act_id", activityDetail.act_id)
            ViewBag.user_id = New SelectList(db.UserAccounts, "user_id", "first_name", activityDetail.user_id)
            Return View(activityDetail)
        End Function

        ' POST: ActivityDetails/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="act_det_id,user_id,act_id,date,start_time,end_time,location,execute_status,description,cost")> ByVal activityDetail As ActivityDetail) As ActionResult
            If ModelState.IsValid Then
                db.Entry(activityDetail).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.act_id = New SelectList(db.Activities, "act_id", "act_id", activityDetail.act_id)
            ViewBag.user_id = New SelectList(db.UserAccounts, "user_id", "first_name", activityDetail.user_id)
            Return View(activityDetail)
        End Function

        ' GET: ActivityDetails/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activityDetail As ActivityDetail = db.ActivityDetails.Find(id)
            If IsNothing(activityDetail) Then
                Return HttpNotFound()
            End If
            Return View(activityDetail)
        End Function

        ' POST: ActivityDetails/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim activityDetail As ActivityDetail = db.ActivityDetails.Find(id)
            db.ActivityDetails.Remove(activityDetail)
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
