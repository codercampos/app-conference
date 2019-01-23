using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Conference.Clients.UI
{
    public partial class CodeOfConductPage : ContentPage
    {
        static string porpuseTitle = "Brief and Purpose\n\n";
        static string porpuseContent = "This policy outlines Caribbean Developers Conference’s expectations regarding expected behavior from all Caribbean Developers Conference speakers, collaborators or participants at any event they host or sponsor. We promote freedom of expression and open communication. But we expect all participants to follow our code of conduct. Participants should avoid offending any person they interact with, and minimize the possibility of serious disputes that may disrupt the workplace, event or any community Caribbean Developers Conference interacts with/supports.\n\n";
        static string scopeSubtitle = "Scope\n\n";
        static string scopeContent = "This policy applies to all Caribbean Developers Conference participants, attendees, or collaborators.\n\n";
        static string elementsTitle = "Elements\n\n";
        static string respectSubtilte = "Respect\n\n";
        static string respectContent ="All speakers or attendants should respect their colleagues, event speakers or attendees. Caribbean Developers Conference will not allow any kind of discriminatory behavior, harassment or victimization.\n\n";
        static string harasmentSubtitle = "Harassment Free";
        static string harasmentContent = "Caribbean Developers Conference is dedicated to providing a harassment-free experience for everyone, regardless of gender, sexual/relationship orientation, disability, politics, disease, mental illness or disorder, disability, veteran status, economic status, physical appearance, body size, race, ethnicity, citizenship status, religion, language, or on any other basis.\n\nWe do not tolerate harassment in any form: to, or by anyone. Sexual language and imagery are not appropriate for any venue, talk, community group or any other event where Caribbean Developers Conference is a sponsor or participant. Participants violating these rules may be sanctioned or expelled from the engagement without a refund at the discretion of the organizers.\n\n";
        static string harasmentList = "Harassment includes (but is not limited to):\n\n• Verbal comments that reinforce social structures of domination related to gender, gender identity, and expression, sexual/relationship orientation, disability, physical appearance, body size, rage, age, religion, or any other social conformity\n• Sexual imagery in public places\n• Deliberate intimidation, stalking or following\n• Harassing photography or recording\n• Sustained disruption of talks or other events\n• Inappropriate physical contact\n• Unwelcome sexual attention\n• Advocating for, or encouraging, any of the above behavior";
        static string enforcementSubtitle = "Enforcement\n\n";
        static string enforcementContent = "Participants asked to stop any harassing behavior are expected to comply immediately. If a participant engages in harassing behavior, event organizers retain the right to take any actions to keep the event a welcoming environment for all participants. This includes warning the offender or expulsion from the event without a refund.\n\nEvent organizers may take action to redress anything designed to, or with the clear impact of, disrupting the event or making the environment hostile to any participants.\n\nWe expect participants to follow these rules at all event venues and event related social activities.\n\n";
        static string reportingSubtitle = "Reporting\n\n";
        static string reportingContent = "If someone makes you or anyone else feel unsafe or unwelcome, please report it as soon as possible. As of this writing, event staff will be identified by their “Staff Badge.” Additional means of identifying staff personnel will be provided closer to the event’s date.\n\nWe want you to be happy at our event. People like you make our event a better place.\n\n";
        static string anonymousReportSubtitle = "Anonymous Report\n\n";
        static string anonymousReportContent = "If you do not feel comfortable talking to a staff member directly, you can also report harassment anonymously on our website at https://caribbeandevconf.com (this policy and the report harassment button will be visible in the footer of every page on this site).\n\n";
        static string personalReportSubtitle = "Personal Report\n\n";
        static string personalReportContent = "You can make the report in person by contacting a staff member (with a STAFF Badge).\n\nWhen taking a personal report, our staff will ensure you are safe and cannot be overheard. They may involve other staff to ensure your report is managed properly Once safe, we will ask you to tell us about what happened. We understand this can be upsetting, but we will handle it as respectfully as possible and you can bring someone to support you, if you wish. You won’t be asked to confront anyone, and we will not tell anyone who you are.\n\nOur team will be happy to help you contact hotel/venue security, local law enforcement, local support services, provide escorts or otherwise assist you to feel safe for the duration of the event. We value your attendance.";

        static int TitleFontSize = 18;
        static int SubtitleFontSize = 15;
        static int ContentFontSize = 14;
        
        public static FormattedString Conduct => GetCodeOfConductString();
        
        public CodeOfConductPage()
        {
            InitializeComponent();

            CodeOfConductText.FormattedText = Conduct;
        }

        public static FormattedString GetCodeOfConductString()
        {
            var fs = new FormattedString();
            
            fs.Spans.Add(new Span{Text = porpuseTitle, FontSize = TitleFontSize});            
            fs.Spans.Add(new Span{Text = porpuseContent, FontSize = ContentFontSize});
            fs.Spans.Add(new Span{Text = scopeSubtitle, FontSize = SubtitleFontSize});
            fs.Spans.Add(new Span{Text = scopeContent, FontSize = ContentFontSize});
            fs.Spans.Add(new Span{Text = elementsTitle, FontSize = TitleFontSize});
            fs.Spans.Add(new Span{Text = respectSubtilte, FontSize = SubtitleFontSize});
            fs.Spans.Add(new Span{Text = respectContent, FontSize = ContentFontSize});
            fs.Spans.Add(new Span{Text = harasmentSubtitle, FontSize = SubtitleFontSize});
            fs.Spans.Add(new Span{Text = harasmentContent, FontSize = ContentFontSize});
            fs.Spans.Add(new Span{Text = harasmentList, FontSize = ContentFontSize});
            fs.Spans.Add(new Span{Text = enforcementSubtitle, FontSize = SubtitleFontSize});
            fs.Spans.Add(new Span{Text = enforcementContent, FontSize = ContentFontSize});
            fs.Spans.Add(new Span{Text = reportingSubtitle, FontSize = SubtitleFontSize});
            fs.Spans.Add(new Span{Text = reportingContent, FontSize = ContentFontSize});
            fs.Spans.Add(new Span{Text = anonymousReportSubtitle, FontSize = SubtitleFontSize});
            fs.Spans.Add(new Span{Text = anonymousReportContent, FontSize = ContentFontSize});
            fs.Spans.Add(new Span{Text = personalReportSubtitle, FontSize = SubtitleFontSize});
            fs.Spans.Add(new Span{Text = personalReportContent, FontSize = ContentFontSize});

            return fs;
        }
    }
}

