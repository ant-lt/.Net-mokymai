// Promise is a returned object
// to which you attach a callback
// instead of passing callbacks into a function

const throwCoin = new Promise((resolve, reject) => {
    const rand = Math.random();
    if(rand < 0.5) {
        resolve();
    } else {
        reject();
    }
});

// .then works only if we resolve()
throwCoin.then(() => {
    console.log('Heads(Resolve)');
})
.then(() => {
    console.log('I am in a callback');
})
.catch(() => {
    console.log('Tails(Reject)');
});

const fakeRequest = (url) => {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            const pages = {
				'/users'        : [
					{ id: 1, username: 'Agne' },
					{ id: 5, username: 'Ignas' }
				],
				'/users/1'      : {
					id        : 1,
					username  : 'Agne',
					upvotes   : 1550,
					city      : 'Vilnius',
					topPostId : 454321
				},
				'/users/5'      : {
					id       : 5,
					username : 'Ignas',
					upvotes  : 751,
					city     : 'Kaunas'
				},
				'/posts/454321' : {
					id    : 454321,
					title :
						'Miesto merai kvailioja! Paspauskite, kad suzinotumete daugiau..'
				},
				'/about'        : 'Apie puslapis!'
			};

            const data = pages[url];
            if(data) {
                // Resolve value is optional. That is why we can do resolve()
                resolve({status: 200, data}); // Resolve with a value
            } else {
                reject({status: 404}); // Rejecting with value
            }
        }, 1000);
    });
}