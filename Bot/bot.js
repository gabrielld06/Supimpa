console.log('tarde');
require("dotenv").config();
const Discord = require('discord.js');
const client = new Discord.Client();
client.login(process.env.BOTTOKEN);

client.on('ready', readyDiscord);

function readyDiscord() {
    console.log('del rey ligado');
}

client.on('message', gotMessage);

function gotMessage(msg) {
    console.log(msg.content);
    if (msg.content === '<@!775096717174767707>') {
        msg.reply('le monke');
    }
    else if (msg.channel.id == '775407501860536342' && msg.content === '<@!273483461027692544>') {
        msg.reply('ESTA OCUPADO');
    }
    else if (msg.channel.id == '775407501860536342' && msg.author.id == 265961687381704704) {
        msg.reply('mt cringe cara');
    }
    else if (msg.content === '!server') {
        msg.channel.send(`nome do server: ${msg.guild.name}\ntcholas: ${msg.guild.memberCount}`);
    }
    else if (msg.content === '!vendrame') {
        msg.channel.send('cara que cringe');
    }
    else if (msg.content === '!cringemeter') {
        if (msg.author.id == 265961687381704704) {
            msg.channel.send('1000');
        }
        else {
            const min = Math.ceil(0);
            const max = Math.floor(80);
            const resp = Math.floor(Math.random() * (max - min)) + min;
            msg.channel.send(resp);
        }
    }
}


