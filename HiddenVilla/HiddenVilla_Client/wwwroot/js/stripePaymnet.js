redirectToCheckOut = function (sessionId) {
    var stripe = Stripe('pk_test_51JOOckHmkYzIy3pzW8pgC7iAxuJPmFmjWrY2NSTrGGRYRSHlZeCben49TIx4RVIBNKWapqoqKuy2nj7EyFidKwYE00CQs1CbXc');
    stripe.redirectToCheckOut({
        sessionId: sessionId
    });
}