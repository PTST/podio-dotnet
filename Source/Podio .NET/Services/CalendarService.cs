﻿using System;
using System.Collections.Generic;
using PodioAPI.Models;
using System.Threading.Tasks;

namespace PodioAPI.Services
{
    public class CalendarService
    {
        private readonly Podio _podio;

        public CalendarService(Podio currentInstance)
        {
            _podio = currentInstance;
        }

        /// <summary>
        ///     Returns the items and tasks that are related to the given app.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/calendar/get-app-calendar-22460 </para>
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="dateFrom">The date to return events from</param>
        /// <param name="dateTo">The date to search to</param>
        /// <param name="priority">The minimum priority for the events to return Default value: 1</param>
        /// <returns></returns>
        public async Task<IEnumerable<CalendarEvent>> GetAppCalendar(long appId, DateTime dateFrom, DateTime dateTo,
            long? priority = null)
        {
            string url = string.Format("/calendar/app/{0}/", appId);
            var requestData = new Dictionary<string, string>();
            requestData["date_from"] = dateFrom.ToString("yyyy-MM-dd");
            requestData["date_to"] = dateTo.ToString("yyyy-MM-dd");
            if (priority.HasValue)
                requestData["priority"] = priority.Value.ToString();

            return await _podio.Get<List<CalendarEvent>>(url, requestData);
        }

        /// <summary>
        ///     Returns all items that the user have access to and all tasks that are assigned to the user.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/calendar/get-global-calendar-22458 </para>
        /// </summary>
        /// <param name="dateFrom">The date to return events from</param>
        /// <param name="dateTo">The date to search to</param>
        /// <param name="priority">The minimum priority for the events to return Default value: 1</param>
        /// <returns></returns>
        public async Task<IEnumerable<CalendarEvent>> GetGlobalCalendar(DateTime dateFrom, DateTime dateTo, long? priority = null)
        {
            string url = "/calendar/";
            var requestData = new Dictionary<string, string>();
            requestData["date_from"] = dateFrom.ToString("yyyy-MM-dd");
            requestData["date_to"] = dateTo.ToString("yyyy-MM-dd");
            if (priority.HasValue)
                requestData["priority"] = priority.Value.ToString();

            return await _podio.Get<List<CalendarEvent>>(url, requestData);
        }

        /// <summary>
        ///     Returns the app calendar in the iCal format 90 days longo the future. The CalendarCode / Token can retrieved by
        ///     getting the user status.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/calendar/get-app-calendar-as-ical-22515 </para>
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="userId"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<StringResponse> GetAppCalendarAsiCal(long appId, long userId, string token)
        {
            string url = string.Format("/calendar/app/{0}/ics/{1}/{2}/", appId, userId, token);
            return await _podio.Get<StringResponse>(url: url, returnAsString: true);
        }

        /// <summary>
        ///     Returns the users global calendar in the iCal format 90 days longo the future. The CalendarCode / Token can
        ///     retrieved by getting the user status.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/calendar/get-global-calendar-as-ical-22513 </para>
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<StringResponse> GetGlobalCalendarAsiCal(long userId, string token)
        {
            string url = string.Format("/calendar/ics/{0}/{1}/", userId, token);
            return await _podio.Get<StringResponse>(url: url, returnAsString: true);
        }

        /// <summary>
        ///     Returns all items and tasks that the user have access to in the given space. Tasks with reference to other spaces
        ///     are not returned or tasks with no reference.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/calendar/get-space-calendar-22459 </para>
        /// </summary>
        /// <param name="spaceId"></param>
        /// <param name="dateFrom">The date to return events from</param>
        /// <param name="dateTo">The date to search to</param>
        /// <param name="priority">The minimum priority for the events to return Default value: 1</param>
        /// <returns></returns>
        public async Task<IEnumerable<CalendarEvent>> GetSpaceCalendar(long spaceId, DateTime dateFrom, DateTime dateTo,
            long? priority = null)
        {
            string url = string.Format("/calendar/space/{0}/", spaceId);
            var requestData = new Dictionary<string, string>();
            requestData["date_from"] = dateFrom.ToString("yyyy-MM-dd");
            requestData["date_to"] = dateTo.ToString("yyyy-MM-dd");
            if (priority.HasValue)
                requestData["priority"] = priority.Value.ToString();

            return await _podio.Get<List<CalendarEvent>>(url, requestData);
        }

        /// <summary>
        ///     Returns the space calendar in the iCal format 90 days longo the future. The CalendarCode / Token can retrieved by
        ///     getting the user status.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/calendar/get-space-calendar-as-ical-22514 </para>
        /// </summary>
        /// <param name="spaceId"></param>
        /// <param name="userId"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<StringResponse> GetSpaceCalendarAsiCal(long spaceId, long userId, string token)
        {
            string url = string.Format("/calendar/space/{0}/ics/{1}/{2}/", spaceId, userId, token);
            var options = new Dictionary<string, bool>()
            {
                {"return_raw", true}
            };

            return await _podio.Get<StringResponse>(url: url, returnAsString: true);
        }

        /// <summary>
        ///     Returns the calendar for the given task in the iCal format.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/calendar/get-task-calendar-as-ical-10195650 </para>
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="userId"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<StringResponse> GetTaskCalendarAsiCal(long taskId)
        {
            string url = string.Format("/calendar/task/{0}/ics/", taskId);
            return await _podio.Get<StringResponse>(url: url, returnAsString: true);
        }

        /// <summary>
        ///     Returns the calendar summary for the active user.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/calendar/get-calendar-summary-1609256 </para>
        /// </summary>
        /// <param name="limit">The maximum number of events to return in each group Default value: 5</param>
        /// <param name="priority">The minimum priority for the events to return Default value: 1</param>
        /// <returns></returns>
        public async Task<CalendarSummary> GetCalendarSummary(long limit = 5, long priority = 1)
        {
            string url = "/calendar/summary";
            var requestData = new Dictionary<string, string>
            {
                {"limit", limit.ToString()},
                {"priority", priority.ToString()}
            };

            return await _podio.Get<CalendarSummary>(url, requestData);
        }

        /// <summary>
        ///     Returns the calendar summary for personal tasks and personal spaces and sub-orgs.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/calendar/get-calendar-summary-for-personal-1657903 </para>
        /// </summary>
        /// <param name="limit">The maximum number of events to return in each group Default value: 5</param>
        /// <param name="priority">The minimum priority for the events to return Default value: 1</param>
        /// <returns></returns>
        public async Task<CalendarSummary> GetCalendarSummaryForPersonal(long limit = 5, long priority = 1)
        {
            string url = "/calendar/personal/summary";
            var requestData = new Dictionary<string, string>
            {
                {"limit", limit.ToString()},
                {"priority", priority.ToString()}
            };

            return await _podio.Get<CalendarSummary>(url, requestData);
        }

        /// <summary>
        ///     Returns the calendar summary for the given space for the active user.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/calendar/get-calendar-summary-for-space-1609328 </para>
        /// </summary>
        /// <param name="spaceId"></param>
        /// <param name="limit">The maximum number of events to return in each group Default value: 5</param>
        /// <param name="priority">The minimum priority for the events to return Default value: 1</param>
        /// <returns></returns>
        public async Task<CalendarSummary> GetCalendarSummaryForSpace(long spaceId, long limit = 5, long priority = 1)
        {
            string url = string.Format("/calendar/space/{0}/summary", spaceId);
            var requestData = new Dictionary<string, string>
            {
                {"limit", limit.ToString()},
                {"priority", priority.ToString()}
            };

            return await _podio.Get<CalendarSummary>(url, requestData);
        }


        /// Update the calendar event with the given UID with a new start and end time. All dates and times should be given in the users local timezone.
        /// <para>Podio API Reference: https://developers.podio.com/doc/calendar/update-calendar-event-78177950 </para>
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="startDateTime"></param>
        /// <param name="endDateTime"></param>
        public async Task<dynamic> UpdateCalendarEvent(long uid, DateTime startDateTime, DateTime endDateTime)
        {
            string url = string.Format("/calendar/event/{0}", uid);
            dynamic requestData = new
            {
                start_date = startDateTime.Date,
                start_time = startDateTime.TimeOfDay,
                end_date = endDateTime.Date,
                end_time = endDateTime.TimeOfDay
            };
           return await _podio.Put<dynamic>(url, requestData);
        }
    }
}