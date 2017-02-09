Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace DailyActivitiesUser
    Public Class UserController
        Inherits System.Web.Mvc.Controller

        Private db As New DailyActivityDBEntities

        ' GET: /User/
        Function Index() As ActionResult
            Dim users = db.Users.Include(Function(u) u.ActivityDetail).Include(Function(u) u.Job)
            Return View(users.ToList())
        End Function

        ' GET: /User/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim user As User = db.Users.Find(id)
            If IsNothing(user) Then
                Return HttpNotFound()
            End If
            Return View(user)
        End Function

        ' GET: /User/Create
        Function Create() As ActionResult
            ViewBag.user_id = New SelectList(db.ActivityDetails, "act_det_id", "location")
            ViewBag.job_id = New SelectList(db.Jobs, "job_id", "jon_name")
            Return View()
        End Function

        ' POST: /User/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "user_id,user_name,gender,dob,pob,job_id,job_place,civil_status,tel,email")> ByVal user As User) As ActionResult
            If ModelState.IsValid Then
                db.Users.Add(user)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.user_id = New SelectList(db.ActivityDetails, "act_det_id", "location", user.user_id)
            ViewBag.job_id = New SelectList(db.Jobs, "job_id", "jon_name", user.job_id)
            Return View(user)
        End Function

        ' GET: /User/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim user As User = db.Users.Find(id)
            If IsNothing(user) Then
                Return HttpNotFound()
            End If
            ViewBag.user_id = New SelectList(db.ActivityDetails, "act_det_id", "location", user.user_id)
            ViewBag.job_id = New SelectList(db.Jobs, "job_id", "jon_name", user.job_id)
            Return View(user)
        End Function

        ' POST: /User/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "user_id,user_name,gender,dob,pob,job_id,job_place,civil_status,tel,email")> ByVal user As User) As ActionResult
            If ModelState.IsValid Then
                db.Entry(user).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.user_id = New SelectList(db.ActivityDetails, "act_det_id", "location", user.user_id)
            ViewBag.job_id = New SelectList(db.Jobs, "job_id", "jon_name", user.job_id)
            Return View(user)
        End Function

        ' GET: /User/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim user As User = db.Users.Find(id)
            If IsNothing(user) Then
                Return HttpNotFound()
            End If
            Return View(user)
        End Function

        ' POST: /User/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim user As User = db.Users.Find(id)
            db.Users.Remove(user)
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
