 if(command === 'play pokoe'){
        const voiceChannel = message.member.voice.channel;
        const permissions = voiceChannel.permissionsFor(message.client.user);

        // if not connected to a channel 
        if(!voiceChannel) return message.channel.send("you need to be in a voice channel to use this command");
        // Rights to connect or speak with a voice channel
        if (!permissions.has('CONNECT')) return message.channel.send("Bonkie bot does not have the permission to connect to this voicechannel");
        if (!permissions.has('SPEAK')) return message.channel.send("Bonkie bot does not have the permission to play a pokoe in this voice channel")

        try {
            var connection = await voiceChannel.join();
        } catch (error) {
            console.log(`there was an error connecting to the voice channel: ${error} `)
            message.channel.send(`there was an error connecting to the voice channel: ${error}`)
        }

        const dispatcher = connection.play(ytdl(args[1]))
        .on('finish', () =>{
            voiceChannel.leave()

        })
        .on('error', error => {
            console.log(error)
        })
        dispatcher.setVolumeLogarithmic(5/5)
    }else if(command == 'stop'){
        if(!message.member.voice.channel) return message.channel.send("you must to be in a voice channel to cancel culture")
        message.member.voice.channel.leave();
        return undefined;
    }   
